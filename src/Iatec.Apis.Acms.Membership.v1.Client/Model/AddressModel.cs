/* 
 * Acms Api
 *
 * The documentation for the ACMS Api
 *
 * OpenAPI spec version: 1.0.1
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Iatec.Apis.Acms.Membership.v1.Client.Model
{
    /// <summary>
    /// AddressModel
    /// </summary>
    [DataContract]
    public partial class AddressModel :  IEquatable<AddressModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressModel" /> class.
        /// </summary>
        /// <param name="Description">Description.</param>
        /// <param name="Complement">Complement.</param>
        /// <param name="PostalCode">PostalCode.</param>
        /// <param name="LatitudeNumber">LatitudeNumber.</param>
        /// <param name="LongitudeNumber">LongitudeNumber.</param>
        /// <param name="City">City.</param>
        public AddressModel(string Description = default(string), string Complement = default(string), string PostalCode = default(string), double? LatitudeNumber = default(double?), double? LongitudeNumber = default(double?), CityModel City = default(CityModel))
        {
            this.Description = Description;
            this.Complement = Complement;
            this.PostalCode = PostalCode;
            this.LatitudeNumber = LatitudeNumber;
            this.LongitudeNumber = LongitudeNumber;
            this.City = City;
        }
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets Complement
        /// </summary>
        [DataMember(Name="Complement", EmitDefaultValue=false)]
        public string Complement { get; set; }
        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>
        [DataMember(Name="PostalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }
        /// <summary>
        /// Gets or Sets LatitudeNumber
        /// </summary>
        [DataMember(Name="LatitudeNumber", EmitDefaultValue=false)]
        public double? LatitudeNumber { get; set; }
        /// <summary>
        /// Gets or Sets LongitudeNumber
        /// </summary>
        [DataMember(Name="LongitudeNumber", EmitDefaultValue=false)]
        public double? LongitudeNumber { get; set; }
        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="City", EmitDefaultValue=false)]
        public CityModel City { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddressModel {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Complement: ").Append(Complement).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  LatitudeNumber: ").Append(LatitudeNumber).Append("\n");
            sb.Append("  LongitudeNumber: ").Append(LongitudeNumber).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as AddressModel);
        }

        /// <summary>
        /// Returns true if AddressModel instances are equal
        /// </summary>
        /// <param name="other">Instance of AddressModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddressModel other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Complement == other.Complement ||
                    this.Complement != null &&
                    this.Complement.Equals(other.Complement)
                ) && 
                (
                    this.PostalCode == other.PostalCode ||
                    this.PostalCode != null &&
                    this.PostalCode.Equals(other.PostalCode)
                ) && 
                (
                    this.LatitudeNumber == other.LatitudeNumber ||
                    this.LatitudeNumber != null &&
                    this.LatitudeNumber.Equals(other.LatitudeNumber)
                ) && 
                (
                    this.LongitudeNumber == other.LongitudeNumber ||
                    this.LongitudeNumber != null &&
                    this.LongitudeNumber.Equals(other.LongitudeNumber)
                ) && 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Complement != null)
                    hash = hash * 59 + this.Complement.GetHashCode();
                if (this.PostalCode != null)
                    hash = hash * 59 + this.PostalCode.GetHashCode();
                if (this.LatitudeNumber != null)
                    hash = hash * 59 + this.LatitudeNumber.GetHashCode();
                if (this.LongitudeNumber != null)
                    hash = hash * 59 + this.LongitudeNumber.GetHashCode();
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
