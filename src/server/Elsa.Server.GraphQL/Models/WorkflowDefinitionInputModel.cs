﻿using System.Collections.Generic;
using Elsa.Models;

namespace Elsa.Server.GraphQL.Models
{
    public class WorkflowDefinitionInputModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsSingleton { get; set; }
        public bool IsDisabled { get; set; }
        public bool Publish { get; set; }
        public IReadOnlyCollection<ActivityDefinitionInputModel> Activities { get; set; }
        public IReadOnlyCollection<ConnectionDefinition> Connections { get; set; }
    }
}