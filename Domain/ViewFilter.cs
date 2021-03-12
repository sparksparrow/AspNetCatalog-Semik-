using GnomShop.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GnomShop.Domain
{
    public class ViewFilter<T> where T : ProductItem
    {
        public string SearchString { get; private set; }
        public ushort MinValue { get; private set; }
        public ushort MaxValue { get; private set; }
        public Dictionary<ProductItemType, bool> ProductItemType { get; private set; }
        public Dictionary<double,bool> SizeValues { get; private set; }
        public Dictionary<string, bool> Colors { get; private set; }


        public ViewFilter(string searchString = default, ushort minValue = default, ushort maxValue = default, Dictionary<ProductItemType, bool> productItemTypes = default, Dictionary<double, bool> sizeValues = default, Dictionary<string, bool> colors = default)
        {
            SearchString = searchString;
            MinValue = minValue;
            MaxValue = maxValue;
            SizeValues = sizeValues;
            ProductItemType = productItemTypes;
            Colors = colors;
        }

        protected IQueryable<T> FilterSearchString(IQueryable<T> source)
        {
            if (!String.IsNullOrEmpty(SearchString))
            {
                return source.Where(s => s.Name.Contains(SearchString));
            }
            return source;
        }

        protected IQueryable<T> FilterPrices(IQueryable<T> source)
        {
            var selectedProducts = source.Where(p => p.TotalPrice >= MinValue);
            if (MaxValue != default && MaxValue > MinValue)
            {
                selectedProducts = selectedProducts.Where(p => p.TotalPrice <= MaxValue); 
            }
            else
            {
                MaxValue = default;
            }
            if (selectedProducts.Any())
            {
                return selectedProducts;
            }
            return source;
        }

        protected IQueryable<T> FilterSizes(IQueryable<T> source)
        {
            IEnumerable<double> selectedSizeValues = SizeValues.Where(size => size.Value).ToDictionary(pair => pair.Key, pair => pair.Value).Keys;

            if (selectedSizeValues.Any())
            {
                var tempIds = source
                    .Select(p => p.Sizes)
                    .ToList()
                    .Where
                    (
                        p => p.Select(p=>p.SizeValue)
                        .Intersect(selectedSizeValues)
                        .Any()
                    )
                    .Select(s=>s.FirstOrDefault().ProductItemId)
                    .Distinct();

                source = source.Where(s=> tempIds.Contains(s.Id));
            }

            return source;
        }

        protected IQueryable<T> FilterTypes(IQueryable<T> source)
        {
            IEnumerable<ProductItemType> selectedTypeValues = ProductItemType.Where(type => type.Value).ToDictionary(pair => pair.Key, pair => pair.Value).Keys;

            if (selectedTypeValues.Any())
            {    
                source = source.Where(p=>selectedTypeValues.Contains(p.ProductItemType));
            }
            return source;
        }

        protected IQueryable<T> FilterColors(IQueryable<T> source)
        {
            IEnumerable<string> selectedColors = Colors.Where(color => color.Value).ToDictionary(pair => pair.Key, pair => pair.Value).Keys;

            if (selectedColors.Any())
            {
                source = source.Where(p => selectedColors.Contains(p.Color));
            }
            return source;
        }

        public IQueryable<T> Filter(IQueryable<T> source)
        {
            source = FilterTypes(source);
            source = FilterSizes(source);
            source = FilterColors(source);
            source = FilterPrices(source);
            source = FilterSearchString(source);
            return source;
        }
    }
}
