using System.Globalization;

// Usamos 'System' em vez 'ExtensionMethos.Extensions' para não ter que importar usando o 'using.Extensions.Extensions';
// Já colocamos a nossa classe no mesmo namespace do tipo que estamos extendendo e não precisaremos acrescentar imports.
namespace System
{
    static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);
            if (duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture);
            }
            else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture);
            }
        }
    }
}