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
        public Dictionary<double,bool> SizeValues { get; private set; }

        public ViewFilter(string searchString = default, ushort minValue = default, ushort maxValue = default, Dictionary<double, bool> sizeValues = default)
        {
            this.SearchString = searchString;
            MinValue = minValue;
            MaxValue = maxValue;
            SizeValues = sizeValues;
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

        public IQueryable<T> Filter(IQueryable<T> source)
        {
            source = FilterSizes(source);
            source = FilterPrices(source);
            source = FilterSearchString(source);
            return source;
        }
    }
}
