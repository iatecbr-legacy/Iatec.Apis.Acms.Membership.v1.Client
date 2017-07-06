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
    /// ChurchModel
    /// </summary>
    [DataContract]
    public partial class ChurchModel :  IEquatable<ChurchModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChurchModel" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Code">Code.</param>
        /// <param name="Name">Name.</param>
        /// <param name="ParentEntity">ParentEntity.</param>
        /// <param name="MainPicture">MainPicture.</param>
        /// <param name="ChurchType">ChurchType.</param>
        /// <param name="Culture">Culture.</param>
        /// <param name="DistrictId">DistrictId.</param>
        /// <param name="DistrictCode">DistrictCode.</param>
        /// <param name="RegionId">RegionId.</param>
        /// <param name="RegionCode">RegionCode.</param>
        /// <param name="MailingAddress">MailingAddress.</param>
        /// <param name="Active">Active.</param>
        /// <param name="MembersAmount">MembersAmount.</param>
        /// <param name="Pastors">Pastors.</param>
        /// <param name="Features">Features.</param>
        /// <param name="ServiceTimes">ServiceTimes.</param>
        /// <param name="StreetAddress">StreetAddress.</param>
        public ChurchModel(Guid? Id = default(Guid?), int? Code = default(int?), string Name = default(string), ParentEntityModel ParentEntity = default(ParentEntityModel), PictureModel MainPicture = default(PictureModel), int? ChurchType = default(int?), CultureModel Culture = default(CultureModel), Guid? DistrictId = default(Guid?), int? DistrictCode = default(int?), Guid? RegionId = default(Guid?), int? RegionCode = default(int?), AddressModel MailingAddress = default(AddressModel), bool? Active = default(bool?), int? MembersAmount = default(int?), List<PastorModel> Pastors = default(List<PastorModel>), List<FeatureModel> Features = default(List<FeatureModel>), List<ServiceTimeModel> ServiceTimes = default(List<ServiceTimeModel>), AddressModel StreetAddress = default(AddressModel))
        {
            this.Id = Id;
            this.Code = Code;
            this.Name = Name;
            this.ParentEntity = ParentEntity;
            this.MainPicture = MainPicture;
            this.ChurchType = ChurchType;
            this.Culture = Culture;
            this.DistrictId = DistrictId;
            this.DistrictCode = DistrictCode;
            this.RegionId = RegionId;
            this.RegionCode = RegionCode;
            this.MailingAddress = MailingAddress;
            this.Active = Active;
            this.MembersAmount = MembersAmount;
            this.Pastors = Pastors;
            this.Features = Features;
            this.ServiceTimes = ServiceTimes;
            this.StreetAddress = StreetAddress;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="Code", EmitDefaultValue=false)]
        public int? Code { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets ParentEntity
        /// </summary>
        [DataMember(Name="ParentEntity", EmitDefaultValue=false)]
        public ParentEntityModel ParentEntity { get; set; }
        /// <summary>
        /// Gets or Sets MainPicture
        /// </summary>
        [DataMember(Name="MainPicture", EmitDefaultValue=false)]
        public PictureModel MainPicture { get; set; }
        /// <summary>
        /// Gets or Sets ChurchType
        /// </summary>
        [DataMember(Name="ChurchType", EmitDefaultValue=false)]
        public int? ChurchType { get; set; }
        /// <summary>
        /// Gets or Sets Culture
        /// </summary>
        [DataMember(Name="Culture", EmitDefaultValue=false)]
        public CultureModel Culture { get; set; }
        /// <summary>
        /// Gets or Sets DistrictId
        /// </summary>
        [DataMember(Name="DistrictId", EmitDefaultValue=false)]
        public Guid? DistrictId { get; set; }
        /// <summary>
        /// Gets or Sets DistrictCode
        /// </summary>
        [DataMember(Name="DistrictCode", EmitDefaultValue=false)]
        public int? DistrictCode { get; set; }
        /// <summary>
        /// Gets or Sets RegionId
        /// </summary>
        [DataMember(Name="RegionId", EmitDefaultValue=false)]
        public Guid? RegionId { get; set; }
        /// <summary>
        /// Gets or Sets RegionCode
        /// </summary>
        [DataMember(Name="RegionCode", EmitDefaultValue=false)]
        public int? RegionCode { get; set; }
        /// <summary>
        /// Gets or Sets MailingAddress
        /// </summary>
        [DataMember(Name="MailingAddress", EmitDefaultValue=false)]
        public AddressModel MailingAddress { get; set; }
        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="Active", EmitDefaultValue=false)]
        public bool? Active { get; set; }
        /// <summary>
        /// Gets or Sets MembersAmount
        /// </summary>
        [DataMember(Name="MembersAmount", EmitDefaultValue=false)]
        public int? MembersAmount { get; set; }
        /// <summary>
        /// Gets or Sets Pastors
        /// </summary>
        [DataMember(Name="Pastors", EmitDefaultValue=false)]
        public List<PastorModel> Pastors { get; set; }
        /// <summary>
        /// Gets or Sets Features
        /// </summary>
        [DataMember(Name="Features", EmitDefaultValue=false)]
        public List<FeatureModel> Features { get; set; }
        /// <summary>
        /// Gets or Sets ServiceTimes
        /// </summary>
        [DataMember(Name="ServiceTimes", EmitDefaultValue=false)]
        public List<ServiceTimeModel> ServiceTimes { get; set; }
        /// <summary>
        /// Gets or Sets StreetAddress
        /// </summary>
        [DataMember(Name="StreetAddress", EmitDefaultValue=false)]
        public AddressModel StreetAddress { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChurchModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ParentEntity: ").Append(ParentEntity).Append("\n");
            sb.Append("  MainPicture: ").Append(MainPicture).Append("\n");
            sb.Append("  ChurchType: ").Append(ChurchType).Append("\n");
            sb.Append("  Culture: ").Append(Culture).Append("\n");
            sb.Append("  DistrictId: ").Append(DistrictId).Append("\n");
            sb.Append("  DistrictCode: ").Append(DistrictCode).Append("\n");
            sb.Append("  RegionId: ").Append(RegionId).Append("\n");
            sb.Append("  RegionCode: ").Append(RegionCode).Append("\n");
            sb.Append("  MailingAddress: ").Append(MailingAddress).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  MembersAmount: ").Append(MembersAmount).Append("\n");
            sb.Append("  Pastors: ").Append(Pastors).Append("\n");
            sb.Append("  Features: ").Append(Features).Append("\n");
            sb.Append("  ServiceTimes: ").Append(ServiceTimes).Append("\n");
            sb.Append("  StreetAddress: ").Append(StreetAddress).Append("\n");
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
            return this.Equals(obj as ChurchModel);
        }

        /// <summary>
        /// Returns true if ChurchModel instances are equal
        /// </summary>
        /// <param name="other">Instance of ChurchModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChurchModel other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.ParentEntity == other.ParentEntity ||
                    this.ParentEntity != null &&
                    this.ParentEntity.Equals(other.ParentEntity)
                ) && 
                (
                    this.MainPicture == other.MainPicture ||
                    this.MainPicture != null &&
                    this.MainPicture.Equals(other.MainPicture)
                ) && 
                (
                    this.ChurchType == other.ChurchType ||
                    this.ChurchType != null &&
                    this.ChurchType.Equals(other.ChurchType)
                ) && 
                (
                    this.Culture == other.Culture ||
                    this.Culture != null &&
                    this.Culture.Equals(other.Culture)
                ) && 
                (
                    this.DistrictId == other.DistrictId ||
                    this.DistrictId != null &&
                    this.DistrictId.Equals(other.DistrictId)
                ) && 
                (
                    this.DistrictCode == other.DistrictCode ||
                    this.DistrictCode != null &&
                    this.DistrictCode.Equals(other.DistrictCode)
                ) && 
                (
                    this.RegionId == other.RegionId ||
                    this.RegionId != null &&
                    this.RegionId.Equals(other.RegionId)
                ) && 
                (
                    this.RegionCode == other.RegionCode ||
                    this.RegionCode != null &&
                    this.RegionCode.Equals(other.RegionCode)
                ) && 
                (
                    this.MailingAddress == other.MailingAddress ||
                    this.MailingAddress != null &&
                    this.MailingAddress.Equals(other.MailingAddress)
                ) && 
                (
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
                ) && 
                (
                    this.MembersAmount == other.MembersAmount ||
                    this.MembersAmount != null &&
                    this.MembersAmount.Equals(other.MembersAmount)
                ) && 
                (
                    this.Pastors == other.Pastors ||
                    this.Pastors != null &&
                    this.Pastors.SequenceEqual(other.Pastors)
                ) && 
                (
                    this.Features == other.Features ||
                    this.Features != null &&
                    this.Features.SequenceEqual(other.Features)
                ) && 
                (
                    this.ServiceTimes == other.ServiceTimes ||
                    this.ServiceTimes != null &&
                    this.ServiceTimes.SequenceEqual(other.ServiceTimes)
                ) && 
                (
                    this.StreetAddress == other.StreetAddress ||
                    this.StreetAddress != null &&
                    this.StreetAddress.Equals(other.StreetAddress)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.ParentEntity != null)
                    hash = hash * 59 + this.ParentEntity.GetHashCode();
                if (this.MainPicture != null)
                    hash = hash * 59 + this.MainPicture.GetHashCode();
                if (this.ChurchType != null)
                    hash = hash * 59 + this.ChurchType.GetHashCode();
                if (this.Culture != null)
                    hash = hash * 59 + this.Culture.GetHashCode();
                if (this.DistrictId != null)
                    hash = hash * 59 + this.DistrictId.GetHashCode();
                if (this.DistrictCode != null)
                    hash = hash * 59 + this.DistrictCode.GetHashCode();
                if (this.RegionId != null)
                    hash = hash * 59 + this.RegionId.GetHashCode();
                if (this.RegionCode != null)
                    hash = hash * 59 + this.RegionCode.GetHashCode();
                if (this.MailingAddress != null)
                    hash = hash * 59 + this.MailingAddress.GetHashCode();
                if (this.Active != null)
                    hash = hash * 59 + this.Active.GetHashCode();
                if (this.MembersAmount != null)
                    hash = hash * 59 + this.MembersAmount.GetHashCode();
                if (this.Pastors != null)
                    hash = hash * 59 + this.Pastors.GetHashCode();
                if (this.Features != null)
                    hash = hash * 59 + this.Features.GetHashCode();
                if (this.ServiceTimes != null)
                    hash = hash * 59 + this.ServiceTimes.GetHashCode();
                if (this.StreetAddress != null)
                    hash = hash * 59 + this.StreetAddress.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
