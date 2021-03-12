namespace GnomShop.Services
{
    public class Config
    {
        public static string ConnectionString { get; set; }
        public static string CompanyName { get; set; }
        public static string CompanyPhone { get; set; }
        public static string CompanyPhoneShort { get; set; }
        public static string CompanyPhoneSecond { get; set; }
        public static string CompanyPhoneSecondShort { get; set; }
        public static string CompanyEmail { get; set; }
        public static string CompanyVK { get; set; }
        public static string CompanyInstagram { get; set; }
        public static string CompanyAdress { get; set; }        
        public static long FileSizeLimit { get; set; }
        public static string[] PermittedExtensions { get; set; }
    }
}
