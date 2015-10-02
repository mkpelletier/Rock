//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// <copyright>
// Copyright 2013 by the Spark Development Network
//
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
//
using System;
using System.Collections.Generic;


namespace Rock.Client
{
    /// <summary>
    /// Base client model for BenevolenceRequest that only includes the non-virtual fields. Use this for PUT/POSTs
    /// </summary>
    public partial class BenevolenceRequestEntity
    {
        /// <summary />
        public int Id { get; set; }

        /// <summary />
        public int? CaseWorkerPersonAliasId { get; set; }

        /// <summary />
        public string CellPhoneNumber { get; set; }

        /// <summary />
        public int? ConnectionStatusValueId { get; set; }

        /// <summary />
        public string Email { get; set; }

        /// <summary />
        public string FirstName { get; set; }

        /// <summary />
        public Guid? ForeignGuid { get; set; }

        /// <summary />
        public string ForeignKey { get; set; }

        /// <summary />
        public string GovernmentId { get; set; }

        /// <summary />
        public string HomePhoneNumber { get; set; }

        /// <summary />
        public string LastName { get; set; }

        /// <summary />
        public int? LocationId { get; set; }

        /// <summary>
        /// If the ModifiedByPersonAliasId is being set manually and should not be overwritten with current user when saved, set this value to true
        /// </summary>
        public bool ModifiedAuditValuesAlreadyUpdated { get; set; }

        /// <summary />
        public DateTime RequestDateTime { get; set; }

        /// <summary />
        public int? RequestedByPersonAliasId { get; set; }

        /// <summary />
        public int? RequestStatusValueId { get; set; }

        /// <summary />
        public string RequestText { get; set; }

        /// <summary />
        public string ResultSummary { get; set; }

        /// <summary />
        public string WorkPhoneNumber { get; set; }

        /// <summary>
        /// Leave this as NULL to let Rock set this
        /// </summary>
        public DateTime? CreatedDateTime { get; set; }

        /// <summary>
        /// This does not need to be set or changed. Rock will always set this to the current date/time when saved to the database.
        /// </summary>
        public DateTime? ModifiedDateTime { get; set; }

        /// <summary>
        /// Leave this as NULL to let Rock set this
        /// </summary>
        public int? CreatedByPersonAliasId { get; set; }

        /// <summary>
        /// If you need to set this manually, set ModifiedAuditValuesAlreadyUpdated=True to prevent Rock from setting it
        /// </summary>
        public int? ModifiedByPersonAliasId { get; set; }

        /// <summary />
        public Guid Guid { get; set; }

        /// <summary />
        public int? ForeignId { get; set; }

        /// <summary>
        /// Copies the base properties from a source BenevolenceRequest object
        /// </summary>
        /// <param name="source">The source.</param>
        public void CopyPropertiesFrom( BenevolenceRequest source )
        {
            this.Id = source.Id;
            this.CaseWorkerPersonAliasId = source.CaseWorkerPersonAliasId;
            this.CellPhoneNumber = source.CellPhoneNumber;
            this.ConnectionStatusValueId = source.ConnectionStatusValueId;
            this.Email = source.Email;
            this.FirstName = source.FirstName;
            this.ForeignGuid = source.ForeignGuid;
            this.ForeignKey = source.ForeignKey;
            this.GovernmentId = source.GovernmentId;
            this.HomePhoneNumber = source.HomePhoneNumber;
            this.LastName = source.LastName;
            this.LocationId = source.LocationId;
            this.ModifiedAuditValuesAlreadyUpdated = source.ModifiedAuditValuesAlreadyUpdated;
            this.RequestDateTime = source.RequestDateTime;
            this.RequestedByPersonAliasId = source.RequestedByPersonAliasId;
            this.RequestStatusValueId = source.RequestStatusValueId;
            this.RequestText = source.RequestText;
            this.ResultSummary = source.ResultSummary;
            this.WorkPhoneNumber = source.WorkPhoneNumber;
            this.CreatedDateTime = source.CreatedDateTime;
            this.ModifiedDateTime = source.ModifiedDateTime;
            this.CreatedByPersonAliasId = source.CreatedByPersonAliasId;
            this.ModifiedByPersonAliasId = source.ModifiedByPersonAliasId;
            this.Guid = source.Guid;
            this.ForeignId = source.ForeignId;

        }
    }

    /// <summary>
    /// Client model for BenevolenceRequest that includes all the fields that are available for GETs. Use this for GETs (use BenevolenceRequestEntity for POST/PUTs)
    /// </summary>
    public partial class BenevolenceRequest : BenevolenceRequestEntity
    {
        /// <summary />
        public ICollection<BenevolenceResult> BenevolenceResults { get; set; }

        /// <summary />
        public PersonAlias CaseWorkerPersonAlias { get; set; }

        /// <summary />
        public DefinedValue ConnectionStatusValue { get; set; }

        /// <summary />
        public Location Location { get; set; }

        /// <summary />
        public PersonAlias RequestedByPersonAlias { get; set; }

        /// <summary />
        public DefinedValue RequestStatusValue { get; set; }

        /// <summary>
        /// NOTE: Attributes are only populated when ?loadAttributes is specified. Options for loadAttributes are true, false, 'simple', 'expanded' 
        /// </summary>
        public Dictionary<string, Rock.Client.Attribute> Attributes { get; set; }

        /// <summary>
        /// NOTE: AttributeValues are only populated when ?loadAttributes is specified. Options for loadAttributes are true, false, 'simple', 'expanded' 
        /// </summary>
        public Dictionary<string, Rock.Client.AttributeValue> AttributeValues { get; set; }
    }
}
