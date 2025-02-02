using Cmf.Common.Cli.Commands;
using System;
using System.Threading.Tasks;

namespace Cmf.Common.Cli.Builders
{
    /// <summary>
    ///
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Cmf.Common.Cli.Builders.IBuildCommand" />
    public class ExecuteCommand<T> : IBuildCommand where T : BaseCommand
    {
        /// <summary>
        /// Gets or sets the command.
        /// </summary>
        /// <value>
        /// The command.
        /// </value>
        public T Command { get; set; }

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        /// <value>
        /// The display name.
        /// </value>
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the execute.
        /// </summary>
        /// <value>
        /// The execute.
        /// </value>
        public Action<T> Execute { get; set; }

        /// <summary>
        /// Executes this instance.
        /// </summary>
        /// <returns></returns>
        public Task Exec()
        {
            dynamic command = this.Command;
            if (this.Execute != null)
            {
                this.Execute(this.Command);
            }
            else
            {
                command.Execute();
            }

            return null;
        }
    }
}