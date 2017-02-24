﻿using System;
using System.Collections.Generic;
using System.Reflection;

namespace LinqToGraphQL.Syntax
{
    public interface ISelectionSet : ISyntaxNode
    {
        Type ResultType { get; set; }
        IList<ISyntaxNode> Selections { get; }
    }
}