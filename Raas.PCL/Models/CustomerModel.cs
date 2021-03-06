/*
 * Raas.PCL
 *
 * This file was automatically generated for Tango Card, Inc. by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using TangoCard.Raas;
using TangoCard.Raas.Utilities;


namespace TangoCard.Raas.Models
{
    public class CustomerModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string customerIdentifier;
        private string displayName;
        private string status;
        private DateTime createdAt;
        private List<Models.AccountSummaryModel> accounts;

        /// <summary>
        /// Customer Identifier
        /// </summary>
        [JsonProperty("customerIdentifier")]
        public string CustomerIdentifier 
        { 
            get 
            {
                return this.customerIdentifier; 
            } 
            set 
            {
                this.customerIdentifier = value;
                onPropertyChanged("CustomerIdentifier");
            }
        }

        /// <summary>
        /// Display Name
        /// </summary>
        [JsonProperty("displayName")]
        public string DisplayName 
        { 
            get 
            {
                return this.displayName; 
            } 
            set 
            {
                this.displayName = value;
                onPropertyChanged("DisplayName");
            }
        }

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status")]
        public string Status 
        { 
            get 
            {
                return this.status; 
            } 
            set 
            {
                this.status = value;
                onPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Date Created
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdAt")]
        public DateTime CreatedAt 
        { 
            get 
            {
                return this.createdAt; 
            } 
            set 
            {
                this.createdAt = value;
                onPropertyChanged("CreatedAt");
            }
        }

        /// <summary>
        /// Accounts
        /// </summary>
        [JsonProperty("accounts")]
        public List<Models.AccountSummaryModel> Accounts 
        { 
            get 
            {
                return this.accounts; 
            } 
            set 
            {
                this.accounts = value;
                onPropertyChanged("Accounts");
            }
        }
    }
} 