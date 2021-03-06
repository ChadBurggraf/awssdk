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
    ///Information about a job flow execution.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://elasticmapreduce.amazonaws.com/doc/2009-03-31", IsNullable = false)]
    public class JobFlowExecutionStatusDetail
    {
        private string stateField;
        private string creationDateTimeField;
        private string startDateTimeField;
        private string readyDateTimeField;
        private string endDateTimeField;
        private string lastStateChangeReasonField;

        /// <summary>
        /// Gets and sets the State property.
        /// State of the job flow.
        /// </summary>
        [XmlElementAttribute(ElementName = "State")]
        public string State
        {
            get { return this.stateField; }
            set { this.stateField = value; }
        }

        /// <summary>
        /// Sets the State property
        /// </summary>
        /// <param name="state">State of the job flow.</param>
        /// <returns>this instance</returns>
        public JobFlowExecutionStatusDetail WithState(string state)
        {
            this.stateField = state;
            return this;
        }

        /// <summary>
        /// Checks if State property is set
        /// </summary>
        /// <returns>true if State property is set</returns>
        public bool IsSetState()
        {
            return this.stateField != null;
        }

        /// <summary>
        /// Gets and sets the CreationDateTime property.
        /// Date and time the job flow was created.
        /// </summary>
        [XmlElementAttribute(ElementName = "CreationDateTime")]
        public string CreationDateTime
        {
            get { return this.creationDateTimeField; }
            set { this.creationDateTimeField = value; }
        }

        /// <summary>
        /// Sets the CreationDateTime property
        /// </summary>
        /// <param name="creationDateTime">Date and time the job flow was created.</param>
        /// <returns>this instance</returns>
        public JobFlowExecutionStatusDetail WithCreationDateTime(string creationDateTime)
        {
            this.creationDateTimeField = creationDateTime;
            return this;
        }

        /// <summary>
        /// Checks if CreationDateTime property is set
        /// </summary>
        /// <returns>true if CreationDateTime property is set</returns>
        public bool IsSetCreationDateTime()
        {
            return this.creationDateTimeField != null;
        }

        /// <summary>
        /// Gets and sets the StartDateTime property.
        /// Date and time the job flow started.
        /// </summary>
        [XmlElementAttribute(ElementName = "StartDateTime")]
        public string StartDateTime
        {
            get { return this.startDateTimeField; }
            set { this.startDateTimeField = value; }
        }

        /// <summary>
        /// Sets the StartDateTime property
        /// </summary>
        /// <param name="startDateTime">Date and time the job flow started.</param>
        /// <returns>this instance</returns>
        public JobFlowExecutionStatusDetail WithStartDateTime(string startDateTime)
        {
            this.startDateTimeField = startDateTime;
            return this;
        }

        /// <summary>
        /// Checks if StartDateTime property is set
        /// </summary>
        /// <returns>true if StartDateTime property is set</returns>
        public bool IsSetStartDateTime()
        {
            return this.startDateTimeField != null;
        }

        /// <summary>
        /// Gets and sets the ReadyDateTime property.
        /// The date and time when the job flow was ready to start running bootstrap actions.
        /// </summary>
        [XmlElementAttribute(ElementName = "ReadyDateTime")]
        public string ReadyDateTime
        {
            get { return this.readyDateTimeField; }
            set { this.readyDateTimeField = value; }
        }

        /// <summary>
        /// Sets the ReadyDateTime property
        /// </summary>
        /// <param name="readyDateTime">The date and time when the job flow was ready to start running bootstrap actions.</param>
        /// <returns>this instance</returns>
        public JobFlowExecutionStatusDetail WithReadyDateTime(string readyDateTime)
        {
            this.readyDateTimeField = readyDateTime;
            return this;
        }

        /// <summary>
        /// Checks if ReadyDateTime property is set
        /// </summary>
        /// <returns>true if ReadyDateTime property is set</returns>
        public bool IsSetReadyDateTime()
        {
            return this.readyDateTimeField != null;
        }

        /// <summary>
        /// Gets and sets the EndDateTime property.
        /// Date and time the job flow ended.
        /// </summary>
        [XmlElementAttribute(ElementName = "EndDateTime")]
        public string EndDateTime
        {
            get { return this.endDateTimeField; }
            set { this.endDateTimeField = value; }
        }

        /// <summary>
        /// Sets the EndDateTime property
        /// </summary>
        /// <param name="endDateTime">Date and time the job flow ended.</param>
        /// <returns>this instance</returns>
        public JobFlowExecutionStatusDetail WithEndDateTime(string endDateTime)
        {
            this.endDateTimeField = endDateTime;
            return this;
        }

        /// <summary>
        /// Checks if EndDateTime property is set
        /// </summary>
        /// <returns>true if EndDateTime property is set</returns>
        public bool IsSetEndDateTime()
        {
            return this.endDateTimeField != null;
        }

        /// <summary>
        /// Gets and sets the LastStateChangeReason property.
        /// Explains the last change of Amazon EC2 status.
        /// </summary>
        [XmlElementAttribute(ElementName = "LastStateChangeReason")]
        public string LastStateChangeReason
        {
            get { return this.lastStateChangeReasonField; }
            set { this.lastStateChangeReasonField = value; }
        }

        /// <summary>
        /// Sets the LastStateChangeReason property
        /// </summary>
        /// <param name="lastStateChangeReason">Explains the last change of Amazon EC2 status.</param>
        /// <returns>this instance</returns>
        public JobFlowExecutionStatusDetail WithLastStateChangeReason(string lastStateChangeReason)
        {
            this.lastStateChangeReasonField = lastStateChangeReason;
            return this;
        }

        /// <summary>
        /// Checks if LastStateChangeReason property is set
        /// </summary>
        /// <returns>true if LastStateChangeReason property is set</returns>
        public bool IsSetLastStateChangeReason()
        {
            return this.lastStateChangeReasonField != null;
        }

    }
}
