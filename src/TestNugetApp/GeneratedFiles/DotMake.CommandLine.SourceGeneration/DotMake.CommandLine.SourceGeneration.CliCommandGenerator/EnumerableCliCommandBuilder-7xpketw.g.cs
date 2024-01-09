﻿// <auto-generated />
// Generated by DotMake.CommandLine.SourceGeneration v1.6.2.0
// Roslyn (Microsoft.CodeAnalysis) v4.800.23.57201
// Generation: 1

namespace TestApp.Commands
{
    public class EnumerableCliCommandBuilder : DotMake.CommandLine.CliCommandBuilder
    {
        public EnumerableCliCommandBuilder()
        {
            DefinitionType = typeof(TestApp.Commands.EnumerableCliCommand);
            ParentDefinitionType = null;
            NameCasingConvention = DotMake.CommandLine.CliNameCasingConvention.KebabCase;
            NamePrefixConvention = DotMake.CommandLine.CliNamePrefixConvention.DoubleHyphen;
            ShortFormPrefixConvention = DotMake.CommandLine.CliNamePrefixConvention.SingleHyphen;
            ShortFormAutoGenerate = true;
        }

        private TestApp.Commands.EnumerableCliCommand CreateInstance()
        {
            return new TestApp.Commands.EnumerableCliCommand();
        }

        public override System.CommandLine.Command Build()
        {
            // Command for 'EnumerableCliCommand' class
            var rootCommand = new System.CommandLine.RootCommand()
            {
            };

            var defaultClass = CreateInstance();

            // Option for 'OptEnumerable' property
            var option0 = new System.CommandLine.Option<System.Collections.Generic.IEnumerable<int>>
            (
                "--opt-enumerable",
                GetParseArgument<System.Collections.Generic.IEnumerable<int>, int>
                (
                    array => (int[])array,
                    null
                )
            )
            {
                IsRequired = true,
            };
            option0.AddAlias("-o");
            rootCommand.Add(option0);

            // Option for 'OptList' property
            var option1 = new System.CommandLine.Option<System.Collections.Generic.List<string>>
            (
                "--opt-list",
                GetParseArgument<System.Collections.Generic.List<string>, string>
                (
                    array => new System.Collections.Generic.List<string>((string[])array),
                    null
                )
            )
            {
                IsRequired = true,
            };
            rootCommand.Add(option1);

            // Option for 'OptEnumArray' property
            var option2 = new System.CommandLine.Option<System.IO.FileAccess[]>
            (
                "--opt-enum-array",
                GetParseArgument<System.IO.FileAccess[], System.IO.FileAccess>
                (
                    array => (System.IO.FileAccess[])array,
                    null
                )
            )
            {
                AllowMultipleArgumentsPerToken = true,
                IsRequired = true,
            };
            rootCommand.Add(option2);

            // Option for 'OptCollection' property
            var option3 = new System.CommandLine.Option<System.Collections.ObjectModel.Collection<int?>>
            (
                "--opt-collection",
                GetParseArgument<System.Collections.ObjectModel.Collection<int?>, int?>
                (
                    array => new System.Collections.ObjectModel.Collection<int?>(System.Linq.Enumerable.ToList((int?[])array)),
                    null
                )
            )
            {
                IsRequired = true,
            };
            rootCommand.Add(option3);

            // Option for 'OptHashSet' property
            var option4 = new System.CommandLine.Option<System.Collections.Generic.HashSet<string>>
            (
                "--opt-hash-set",
                GetParseArgument<System.Collections.Generic.HashSet<string>, string>
                (
                    array => new System.Collections.Generic.HashSet<string>((string[])array),
                    null
                )
            )
            {
                IsRequired = true,
            };
            rootCommand.Add(option4);

            // Option for 'OptQueue' property
            var option5 = new System.CommandLine.Option<System.Collections.Generic.Queue<System.IO.FileInfo>>
            (
                "--opt-queue",
                GetParseArgument<System.Collections.Generic.Queue<System.IO.FileInfo>, System.IO.FileInfo>
                (
                    array => new System.Collections.Generic.Queue<System.IO.FileInfo>((System.IO.FileInfo[])array),
                    null
                )
            )
            {
                IsRequired = true,
            };
            rootCommand.Add(option5);

            // Option for 'OptCustomList' property
            var option6 = new System.CommandLine.Option<TestApp.Commands.CustomList<string>>
            (
                "--opt-custom-list",
                GetParseArgument<TestApp.Commands.CustomList<string>, string>
                (
                    array => new TestApp.Commands.CustomList<string>((string[])array),
                    null
                )
            )
            {
                IsRequired = true,
            };
            rootCommand.Add(option6);

            // Argument for 'ArgIList' property
            var argument0 = new System.CommandLine.Argument<System.Collections.IList>
            (
                "arg-ilist",
                GetParseArgument<System.Collections.IList, string>
                (
                    array => (string[])array,
                    null
                )
            )
            {
            };
            argument0.Arity = System.CommandLine.ArgumentArity.OneOrMore;
            rootCommand.Add(argument0);

            // Add nested or external registered children
            foreach (var child in Children)
            {
                rootCommand.Add(child.Build());
            }

            BindFunc = (parseResult) =>
            {
                var targetClass = CreateInstance();

                //  Set the parsed or default values for the options
                targetClass.OptEnumerable = GetValueForOption(parseResult, option0);
                targetClass.OptList = GetValueForOption(parseResult, option1);
                targetClass.OptEnumArray = GetValueForOption(parseResult, option2);
                targetClass.OptCollection = GetValueForOption(parseResult, option3);
                targetClass.OptHashSet = GetValueForOption(parseResult, option4);
                targetClass.OptQueue = GetValueForOption(parseResult, option5);
                targetClass.OptCustomList = GetValueForOption(parseResult, option6);

                //  Set the parsed or default values for the arguments
                targetClass.ArgIList = GetValueForArgument(parseResult, argument0);

                return targetClass;
            };

            System.CommandLine.Handler.SetHandler(rootCommand, context =>
            {
                var targetClass = (TestApp.Commands.EnumerableCliCommand) BindFunc(context.ParseResult);

                //  Call the command handler
                targetClass.Run();
            });

            return rootCommand;
        }

        [System.Runtime.CompilerServices.ModuleInitializerAttribute]
        public static void Initialize()
        {
            var commandBuilder = new TestApp.Commands.EnumerableCliCommandBuilder();

            // Register this command builder so that it can be found by the definition class
            // and it can be found by the parent definition class if it's a nested/external child.
            commandBuilder.Register();
        }
    }
}
