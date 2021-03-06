/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// <para>Contains the result of a successful invocation of the GetGroup
    /// action.</para>
    /// </summary>
    public class GetGroupResult  
    {
        
        private Group group;
        private List<User> users = new List<User>();
        private bool isTruncated;
        private string marker;

        /// <summary>
        /// Information about the group.
        ///  
        /// </summary>
        public Group Group
        {
            get { return this.group; }
            set { this.group = value; }
        }

        /// <summary>
        /// A list of users in the group.
        ///  
        /// </summary>
        public List<User> Users
        {
            get { return this.users; }
            set { this.users = value; }
        }

        /// <summary>
        /// A flag that indicates whether there are more users to list. If your
        /// results were truncated, you can make a follow-up pagination request
        /// using the <c>Marker</c> request parameter to retrieve more users in
        /// the list.
        ///  
        /// </summary>
        public bool IsTruncated
        {
            get { return this.isTruncated; }
            set { this.isTruncated = value; }
        }

        /// <summary>
        /// If IsTruncated is true, then this element is present and contains the
        /// value to use for the <c>Marker</c> parameter in a follow-up pagination
        /// request.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 320</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\u00FF]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }
    }
}
