/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2009-11-25
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.ElasticLoadBalancing.Model
{
    ///<summary>
    ///General representation of an EC2 instance.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://elasticloadbalancing.amazonaws.com/doc/2009-11-25/", IsNullable = false)]
    public class Instance
    {
        private string instanceIdField;

        /// <summary>
        /// Gets and sets the InstanceId property.
        /// An EC2 instance ID.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceId")]
        public string InstanceId
        {
            get { return this.instanceIdField; }
            set { this.instanceIdField = value; }
        }

        /// <summary>
        /// Sets the InstanceId property
        /// </summary>
        /// <param name="instanceId">An EC2 instance ID.</param>
        /// <returns>this instance</returns>
        public Instance WithInstanceId(string instanceId)
        {
            this.instanceIdField = instanceId;
            return this;
        }

        /// <summary>
        /// Checks if InstanceId property is set
        /// </summary>
        /// <returns>true if InstanceId property is set</returns>
        public bool IsSetInstanceId()
        {
            return this.instanceIdField != null;
        }

    }
}
