﻿// ***********************************************************************
// Assembly         : nem2-sdk
// Author           : kailin
// Created          : 01-15-2018
//
// Last Modified By : kailin
// Last Modified On : 01-29-2018
// ***********************************************************************
// <copyright file="NamespaceIds.cs" company="Nem.io">   
// Copyright 2018 NEM
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;

namespace io.nem2.sdk.Infrastructure.Buffers.Model
{
    /// <summary>
    /// Class NamespaceIds.
    /// </summary>
    public class NamespaceIds
    {
        public NamespaceIds()
        {
               namespaceIds = new List<string>();
        }
        /// <summary>
        /// Gets or sets the namespace ids.
        /// </summary>
        /// <value>The namespace ids.</value>
        public List<string> namespaceIds { get; set; }
    }
}
