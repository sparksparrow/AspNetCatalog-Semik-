using GnomShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GnomShop.Services
{
    public static class CollectionProcessor
    {
        public static Dictionary<double, bool> GetSelectedSizeValues(Dictionary<double, bool> dbValues , double[]values , string currentValues)
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
                    ICollection<string> listOfColors = new List<string>();
                    foreach (var color in currentValues.Split(","))
                    {
                        string result = default;
                        if (result == color)
                        {
                            listOfColors.Add(result);
                        }
                    }
                    dbValues = dbValues.Select(s => listOfColors.Contains(s.Key) ? new KeyValuePair<string, bool>(s.Key, true) : s).ToDictionary(pair => pair.Key, pair => pair.Value);
                }
            }
            return dbValues;
        }

        public static Dictionary<Gender, bool> GetSelectedGenderValues(Dictionary<Gender, bool> dbValues, Gender[] values, string currentValues)
        {
            if (values.Any())
            {
                dbValues = dbValues.Select(s => values.Contains(s.Key) ? new KeyValuePair<Gender, bool>(s.Key, true) : s).ToDictionary(pair => pair.Key, pair => pair.Value);
            }
            else
            {
                if (currentValues != default)
                {
                    ICollection<Gender> listOfGenders = new List<Gender>();
                    foreach (var gender in currentValues.Split(","))
                    {
                        Gender result = default;
                        if (Gender.TryParse(gender, out result))
                        {
                            listOfGenders.Add(result);
                        }
                    }
                    dbValues = dbValues.Select(s => listOfGenders.Contains(s.Key) ? new KeyValuePair<Gender, bool>(s.Key, true) : s).ToDictionary(pair => pair.Key, pair => pair.Value);
                }
            }
            return dbValues;
        }

    }
}
