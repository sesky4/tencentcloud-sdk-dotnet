/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Mrs.V20200910.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TreatmentRecord : AbstractModel
    {
        
        /// <summary>
        /// ""
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DmissionCondition")]
        public string DmissionCondition{ get; set; }

        /// <summary>
        /// ""
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChiefComplaint")]
        public string ChiefComplaint{ get; set; }

        /// <summary>
        /// ""
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiseasePresent")]
        public string DiseasePresent{ get; set; }

        /// <summary>
        /// ""
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SymptomsAndSigns")]
        public string SymptomsAndSigns{ get; set; }

        /// <summary>
        /// “”
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AuxiliaryExamination")]
        public string AuxiliaryExamination{ get; set; }

        /// <summary>
        /// “”
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BodyExamination")]
        public string BodyExamination{ get; set; }

        /// <summary>
        /// “”
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SpecialistExamination")]
        public string SpecialistExamination{ get; set; }

        /// <summary>
        /// “”
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MentalExamination")]
        public string MentalExamination{ get; set; }

        /// <summary>
        /// “”
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CheckRecord")]
        public string CheckRecord{ get; set; }

        /// <summary>
        /// “”
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InspectResult")]
        public string InspectResult{ get; set; }

        /// <summary>
        /// “”
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IncisionHealing")]
        public string IncisionHealing{ get; set; }

        /// <summary>
        /// “”
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TreatmentSuggestion")]
        public string TreatmentSuggestion{ get; set; }

        /// <summary>
        /// “”
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FollowUpRequirements")]
        public string FollowUpRequirements{ get; set; }

        /// <summary>
        /// “”
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CheckAndTreatmentProcess")]
        public string CheckAndTreatmentProcess{ get; set; }

        /// <summary>
        /// “”
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SurgeryCondition")]
        public string SurgeryCondition{ get; set; }

        /// <summary>
        /// “”
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConditionChanges")]
        public string ConditionChanges{ get; set; }

        /// <summary>
        /// “”
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DischargeCondition")]
        public string DischargeCondition{ get; set; }

        /// <summary>
        /// “”
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PTNM")]
        public string PTNM{ get; set; }

        /// <summary>
        /// “”
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PTNMM")]
        public string PTNMM{ get; set; }

        /// <summary>
        /// “”
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PTNMN")]
        public string PTNMN{ get; set; }

        /// <summary>
        /// “”
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PTNMT")]
        public string PTNMT{ get; set; }

        /// <summary>
        /// “”
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ECOG")]
        public string ECOG{ get; set; }

        /// <summary>
        /// “”
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NRS")]
        public string NRS{ get; set; }

        /// <summary>
        /// “”
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KPS")]
        public string KPS{ get; set; }

        /// <summary>
        /// “”
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeathDate")]
        public string DeathDate{ get; set; }

        /// <summary>
        /// “”
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RelapseDate")]
        public string RelapseDate{ get; set; }

        /// <summary>
        /// “”
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ObservationDays")]
        public string ObservationDays{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DmissionCondition", this.DmissionCondition);
            this.SetParamSimple(map, prefix + "ChiefComplaint", this.ChiefComplaint);
            this.SetParamSimple(map, prefix + "DiseasePresent", this.DiseasePresent);
            this.SetParamSimple(map, prefix + "SymptomsAndSigns", this.SymptomsAndSigns);
            this.SetParamSimple(map, prefix + "AuxiliaryExamination", this.AuxiliaryExamination);
            this.SetParamSimple(map, prefix + "BodyExamination", this.BodyExamination);
            this.SetParamSimple(map, prefix + "SpecialistExamination", this.SpecialistExamination);
            this.SetParamSimple(map, prefix + "MentalExamination", this.MentalExamination);
            this.SetParamSimple(map, prefix + "CheckRecord", this.CheckRecord);
            this.SetParamSimple(map, prefix + "InspectResult", this.InspectResult);
            this.SetParamSimple(map, prefix + "IncisionHealing", this.IncisionHealing);
            this.SetParamSimple(map, prefix + "TreatmentSuggestion", this.TreatmentSuggestion);
            this.SetParamSimple(map, prefix + "FollowUpRequirements", this.FollowUpRequirements);
            this.SetParamSimple(map, prefix + "CheckAndTreatmentProcess", this.CheckAndTreatmentProcess);
            this.SetParamSimple(map, prefix + "SurgeryCondition", this.SurgeryCondition);
            this.SetParamSimple(map, prefix + "ConditionChanges", this.ConditionChanges);
            this.SetParamSimple(map, prefix + "DischargeCondition", this.DischargeCondition);
            this.SetParamSimple(map, prefix + "PTNM", this.PTNM);
            this.SetParamSimple(map, prefix + "PTNMM", this.PTNMM);
            this.SetParamSimple(map, prefix + "PTNMN", this.PTNMN);
            this.SetParamSimple(map, prefix + "PTNMT", this.PTNMT);
            this.SetParamSimple(map, prefix + "ECOG", this.ECOG);
            this.SetParamSimple(map, prefix + "NRS", this.NRS);
            this.SetParamSimple(map, prefix + "KPS", this.KPS);
            this.SetParamSimple(map, prefix + "DeathDate", this.DeathDate);
            this.SetParamSimple(map, prefix + "RelapseDate", this.RelapseDate);
            this.SetParamSimple(map, prefix + "ObservationDays", this.ObservationDays);
        }
    }
}
