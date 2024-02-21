using Checkpoint.Debugging;

namespace Checkpoint
{
    public class CheckpointConsts
    {
        public const string LocalizationSourceName = "Checkpoint";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "c4c1bb1db76f4614a2ef66bda173a850";
    }
}
