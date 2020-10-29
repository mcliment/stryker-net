﻿namespace Stryker.Core.ProjectComponents
{
    public interface IFileLeaf<T> : IProjectComponent
    {
        T SyntaxTree { get; set; }

        T MutatedSyntaxTree { get; set; }
    }
}
