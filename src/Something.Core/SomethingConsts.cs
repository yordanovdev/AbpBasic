using Something.Debugging;

namespace Something
{
    public class SomethingConsts
    {
        public const string LocalizationSourceName = "Something";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "44826ff3d02240ac821328f155819ba1";
    }
}
