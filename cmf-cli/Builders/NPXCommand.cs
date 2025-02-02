using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Cmf.Common.Cli.Builders
{
    /// <summary>
    /// run npx command
    /// </summary>
    public class NPXCommand : ProcessCommand, IBuildCommand
    {
        /// <summary>
        /// Gets or sets the arguments.
        /// </summary>
        /// <value>
        /// The arguments.
        /// </value>
        public string[] Args { get; set; }
        
        /// <summary>
        /// Gets or sets the command.
        /// </summary>
        /// <value>
        /// The command.
        /// </value>
        public string Command { get; set; }
        
        /// <inheritdoc />
        public override ProcessBuildStep[] GetSteps()
        {
            var args = this.Args?.ToList() ?? new List<string>();
            args.Insert(0, this.Command);
            args.AddRange(new[] { "--color", "always" });
            return new[]
            {
                new ProcessBuildStep()
                {
                    Command = "npx" + (RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? ".cmd" : ""),
                    Args = args.ToArray()
                }
            };
        }

        /// <inheritdoc />
        public string DisplayName { get; set; }
    }
}