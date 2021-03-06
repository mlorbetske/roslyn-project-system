﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using EnvDTE;
using Moq;

namespace Microsoft.VisualStudio.Mocks
{
    internal static class ProjectFactory
    {
        public static Project Create()
        {
            return Mock.Of<Project>();
        }

        public static Project CreateWithSolution(Solution solution)
        {
            var mock = new Mock<Project>();

            mock.SetupGet(p => p.DTE.Solution).Returns(solution);

            return mock.Object;
        }

        internal static void ImplementCodeModelLanguage(Project project, string language)
        {
            var mock = Mock.Get(project);
            mock.SetupGet(p => p.CodeModel.Language).Returns(language);
        }
    }
}
