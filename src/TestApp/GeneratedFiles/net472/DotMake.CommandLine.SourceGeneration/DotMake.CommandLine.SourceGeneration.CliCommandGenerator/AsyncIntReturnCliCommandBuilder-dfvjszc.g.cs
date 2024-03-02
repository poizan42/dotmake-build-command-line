// <auto-generated />
// Generated by DotMake.CommandLine.SourceGeneration v1.8.5.0
// Roslyn (Microsoft.CodeAnalysis) v4.900.24.12101
// Generation: 1

namespace TestApp.Commands.GeneratedCode
{
    /// <inheritdoc />
    public class AsyncIntReturnCliCommandBuilder : DotMake.CommandLine.CliCommandBuilder
    {
        /// <inheritdoc />
        public AsyncIntReturnCliCommandBuilder()
        {
            DefinitionType = typeof(TestApp.Commands.AsyncIntReturnCliCommand);
            ParentDefinitionType = null;
            NameCasingConvention = DotMake.CommandLine.CliNameCasingConvention.KebabCase;
            NamePrefixConvention = DotMake.CommandLine.CliNamePrefixConvention.DoubleHyphen;
            ShortFormPrefixConvention = DotMake.CommandLine.CliNamePrefixConvention.SingleHyphen;
            ShortFormAutoGenerate = true;
        }

        private TestApp.Commands.AsyncIntReturnCliCommand CreateInstance()
        {
            return new TestApp.Commands.AsyncIntReturnCliCommand();
        }

        /// <inheritdoc />
        public override System.CommandLine.CliCommand Build()
        {
            // Command for 'AsyncIntReturnCliCommand' class
            var rootCommand = new System.CommandLine.CliRootCommand()
            {
                Description = "A root cli command with async handler with Task<int> (return int)",
            };

            var defaultClass = CreateInstance();

            // Option for 'Option1' property
            var option0 = new System.CommandLine.CliOption<string>
            (
                "--option-1"
            )
            {
                Description = "Description for Option1",
                Required = false,
                DefaultValueFactory = _ => defaultClass.Option1,
                CustomParser = GetArgumentParser<string>
                (
                    null
                ),
            };
            option0.Aliases.Add("-o");
            rootCommand.Add(option0);

            // Argument for 'Argument1' property
            var argument0 = new System.CommandLine.CliArgument<string>
            (
                "argument-1"
            )
            {
                Description = "Description for Argument1",
                CustomParser = GetArgumentParser<string>
                (
                    null
                ),
            };
            rootCommand.Add(argument0);

            // Add nested or external registered children
            foreach (var child in Children)
            {
                rootCommand.Add(child.Build());
            }

            BindFunc = (cliBindContext) =>
            {
                var targetClass = CreateInstance();

                //  Set the parsed or default values for the options
                targetClass.Option1 = GetValueForOption(cliBindContext.ParseResult, option0);

                //  Set the parsed or default values for the arguments
                targetClass.Argument1 = GetValueForArgument(cliBindContext.ParseResult, argument0);

                //  Set the values for the parent command references

                return targetClass;
            };

            rootCommand.SetAction(async (parseResult, cancellationToken) =>
            {
                var cliBindContext = new DotMake.CommandLine.CliBindContext(parseResult);
                var targetClass = (TestApp.Commands.AsyncIntReturnCliCommand) BindFunc(cliBindContext);

                //  Call the command handler
                var cliContext = new DotMake.CommandLine.CliContext(parseResult, cancellationToken);
                var exitCode = 0;
                exitCode = await targetClass.RunAsync();
                return exitCode;
            });

            return rootCommand;
        }

        [System.Runtime.CompilerServices.ModuleInitializerAttribute]
        internal static void Initialize()
        {
            var commandBuilder = new TestApp.Commands.GeneratedCode.AsyncIntReturnCliCommandBuilder();

            // Register this command builder so that it can be found by the definition class
            // and it can be found by the parent definition class if it's a nested/external child.
            commandBuilder.Register();
        }
    }
}
