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
 *  API Version: 2009-03-31
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.ElasticMapReduce.Model
{
    ///<summary>
    ///Reports the configuration of a bootstrap action in a job flow.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://elasticmapreduce.amazonaws.com/doc/2009-03-31", IsNullable = false)]
    public class BootstrapActionDetail
    {
        private BootstrapActionConfig bootstrapActionConfigField;

        /// <summary>
        /// Gets and sets the BootstrapActionConfig property.
        /// A description of the bootstrap action.
        /// </summary>
        [XmlElementAttribute(ElementName = "BootstrapActionConfig")]
        public BootstrapActionConfig BootstrapActionConfig
        {
            get { return this.bootstrapActionConfigField; }
            set { this.bootstrapActionConfigField = value; }
        }

        /// <summary>
        /// Sets the BootstrapActionConfig property
        /// </summary>
        /// <param name="bootstrapActionConfig">A description of the bootstrap action.</param>
        /// <returns>this instance</returns>
        public BootstrapActionDetail WithBootstrapActionConfig(BootstrapActionConfig bootstrapActionConfig)
        {
            this.bootstrapActionConfigField = bootstrapActionConfig;
            return this;
        }

        /// <summary>
        /// Checks if BootstrapActionConfig property is set
        /// </summary>
        /// <returns>true if BootstrapActionConfig property is set</returns>
        public bool IsSetBootstrapActionConfig()
        {
            return this.bootstrapActionConfigField != null;
        }

    }
}
