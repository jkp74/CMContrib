﻿namespace Caliburn.Micro.Contrib.Interaction
{
    /// <summary>
    ///   Model for a Warning Dialog
    /// </summary>
    public class Warning : Dialog
    {
        public Warning(string message, params Answer[] possibleResponens)
            : base(DialogType.Warning, message, possibleResponens)
        {
        }

        public Warning(string subject, string message, params Answer[] possibleResponens)
            : base(DialogType.Warning, subject, message, possibleResponens)
        {
        }
    }
}