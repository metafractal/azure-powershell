﻿// -----------------------------------------------------------------------------
﻿//
﻿// Copyright Microsoft Corporation
﻿// Licensed under the Apache License, Version 2.0 (the "License");
﻿// you may not use this file except in compliance with the License.
﻿// You may obtain a copy of the License at
﻿// http://www.apache.org/licenses/LICENSE-2.0
﻿// Unless required by applicable law or agreed to in writing, software
﻿// distributed under the License is distributed on an "AS IS" BASIS,
﻿// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
﻿// See the License for the specific language governing permissions and
﻿// limitations under the License.
﻿// -----------------------------------------------------------------------------
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Batch.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Microsoft.Azure.Batch;
    
    
    public class PSComputeNodeUser
    {
        
        internal Microsoft.Azure.Batch.ComputeNodeUser omObject;
        
        internal PSComputeNodeUser(Microsoft.Azure.Batch.ComputeNodeUser omObject)
        {
            if ((omObject == null))
            {
                throw new System.ArgumentNullException("omObject");
            }
            this.omObject = omObject;
        }
        
        public System.DateTime ExpiryTime
        {
            get
            {
                return this.omObject.ExpiryTime;
            }
            set
            {
                this.omObject.ExpiryTime = value;
            }
        }
        
        public System.Boolean? IsAdmin
        {
            get
            {
                return this.omObject.IsAdmin;
            }
            set
            {
                this.omObject.IsAdmin = value;
            }
        }
        
        public string Name
        {
            get
            {
                return this.omObject.Name;
            }
            set
            {
                this.omObject.Name = value;
            }
        }
        
        public string Password
        {
            get
            {
                return this.omObject.Password;
            }
            set
            {
                this.omObject.Password = value;
            }
        }
        
        public string SshPublicKey
        {
            get
            {
                return this.omObject.SshPublicKey;
            }
            set
            {
                this.omObject.SshPublicKey = value;
            }
        }
    }
}
