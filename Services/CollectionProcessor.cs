using GnomShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GnomShop.Services
{
    public static class CollectionProcessor
    {
        public static Dictionary<double, bool> GetSelectedSizeValues(Dictionary<double, bool> dbValues, double[] values, string currentValues)
        {
            if (values.Any())
            {
                dbValues = dbValues.Select(s => values.Contains(s.Key) ? new KeyValuePair<double, bool>(s.Key, true) : s).ToDictionary(pair => pair.Key, pair => pair.Value);
            }
            else
            {
                if (currentValues != default)
                {
                    ICollection<double> listOfSizes = new List<double>();
                    foreach (var size in currentValues.Split(","))
                    {
                        double result = default;
                        if (double.TryParse(size, out result))
                        {
                            listOfSizes.Add(result);
                        }
                    }
                    dbValues = dbValues.Select(s => listOfSizes.Contains(s.Key) ? new KeyValuePair<double, bool>(s.Key, true) : s).ToDictionary(pair => pair.Key, pair => pair.Value);
                }
            }
            return dbValues;
        }
        public static Dictionary<ProductItemType, bool> GetSelectedProductItemTypeValues(Dictionary<ProductItemType, bool> dbValues, ProductItemType[] values, string currentValues)
        {
            if (values.Any())
            {
                dbValues = dbValues.Select(s => values.Contains(s.Key) ? new KeyValuePair<ProductItemType, bool>(s.Key, true) : s).ToDictionary(pair => pair.Key, pair => pair.Value);
            }
            else
            {
                if (currentValues != default)
                {
                    ICollection<ProductItemType> listOfTypes = new List<ProductItemType>();
                    foreach (var type in currentValues.Split(","))
                    {
                        ProductItemType result = default;
                        if (ProductItemType.TryParse(type, out result))
                        {
                            listOfTypes.Add(result);
                        }
                    }
                    dbValues = dbValues.Select(s => listOfTypes.Contains(s.Key) ? new KeyValuePair<ProductItemType, bool>(s.Key, true) : s).ToDictionary(pair => pair.Key, pair => pair.Value);
                }
            }
            return dbValues;
        }

        public static Dictionary<string, bool> GetSelectedColorValues(Dictionary<string, bool> dbValues, string[] values, string currentValues)
        {
            if (values.Any())
            {
                dbValues = dbValues.Select(s => values.Contains(s.Key) ? new KeyValuePair<string, bool>(s.Key, true) : s).ToDictionary(pair => pair.Key, pair => pair.Value);
            }
            else
            {
                if (currentValues != default)
                {
                    ICollection<string> listOfColors = currentValues.Split(",");

                    dbValues = dbValues.Select(s => listOfColors.Contains(s.Key) ? new KeyValuePair<string, bool>(s.Key, true) : s).ToDictionary(pair => pair.Key, pair => pair.Value);
                }
            }
            return dbValues;
        }
    }
}
