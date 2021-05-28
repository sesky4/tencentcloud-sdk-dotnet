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

    public class TuberInfo : AbstractModel
    {
        
        /// <summary>
        /// 类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Type")]
        public BlockInfo Type{ get; set; }

        /// <summary>
        /// 部位
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Part")]
        public Part Part{ get; set; }

        /// <summary>
        /// 大小
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Size")]
        public Size[] Size{ get; set; }

        /// <summary>
        /// 数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Multiple")]
        public Multiple Multiple{ get; set; }

        /// <summary>
        /// 纵横比
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AspectRatio")]
        public AspectRatio AspectRatio{ get; set; }

        /// <summary>
        /// 边缘
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Edge")]
        public BlockInfo Edge{ get; set; }

        /// <summary>
        /// 内部回声
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InnerEcho")]
        public BlockInfo InnerEcho{ get; set; }

        /// <summary>
        /// 外部回声
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RearEcho")]
        public BlockInfo RearEcho{ get; set; }

        /// <summary>
        /// 质地
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Elastic")]
        public Elastic Elastic{ get; set; }

        /// <summary>
        /// 形态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Shape")]
        public BlockInfo Shape{ get; set; }

        /// <summary>
        /// 形态属性
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShapeAttr")]
        public BlockInfo ShapeAttr{ get; set; }

        /// <summary>
        /// “”
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SkinMedulla")]
        public BlockInfo SkinMedulla{ get; set; }

        /// <summary>
        /// “”
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Trend")]
        public BlockInfo Trend{ get; set; }

        /// <summary>
        /// 钙化
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Calcification")]
        public BlockInfo Calcification{ get; set; }

        /// <summary>
        /// 包膜
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Envelope")]
        public BlockInfo Envelope{ get; set; }

        /// <summary>
        /// 强化
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Enhancement")]
        public BlockInfo Enhancement{ get; set; }

        /// <summary>
        /// 淋巴结
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LymphEnlargement")]
        public BlockInfo LymphEnlargement{ get; set; }

        /// <summary>
        /// 淋巴门
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LymphDoor")]
        public BlockInfo LymphDoor{ get; set; }

        /// <summary>
        /// 活动度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Activity")]
        public BlockInfo Activity{ get; set; }

        /// <summary>
        /// “”
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Operation")]
        public BlockInfo Operation{ get; set; }

        /// <summary>
        /// “”
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CDFI")]
        public BlockInfo CDFI{ get; set; }

        /// <summary>
        /// 原文位置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Index")]
        public long?[] Index{ get; set; }

        /// <summary>
        /// “”
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SizeStatus")]
        public BlockInfo SizeStatus{ get; set; }

        /// <summary>
        /// “”
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InnerEchoDistribution")]
        public BlockInfo InnerEchoDistribution{ get; set; }

        /// <summary>
        /// “”
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InnerEchoType")]
        public BlockInfo[] InnerEchoType{ get; set; }

        /// <summary>
        /// “”
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Outline")]
        public BlockInfo Outline{ get; set; }

        /// <summary>
        /// “”
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Structure")]
        public BlockInfo Structure{ get; set; }

        /// <summary>
        /// “”
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Density")]
        public BlockInfo Density{ get; set; }

        /// <summary>
        /// “”
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Vas")]
        public BlockInfo Vas{ get; set; }

        /// <summary>
        /// “”
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Cysticwall")]
        public BlockInfo Cysticwall{ get; set; }

        /// <summary>
        /// “”
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Capsule")]
        public BlockInfo Capsule{ get; set; }

        /// <summary>
        /// “”
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsthmusThicknese")]
        public Size IsthmusThicknese{ get; set; }

        /// <summary>
        /// “”
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Src")]
        public string Src{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Type.", this.Type);
            this.SetParamObj(map, prefix + "Part.", this.Part);
            this.SetParamArrayObj(map, prefix + "Size.", this.Size);
            this.SetParamObj(map, prefix + "Multiple.", this.Multiple);
            this.SetParamObj(map, prefix + "AspectRatio.", this.AspectRatio);
            this.SetParamObj(map, prefix + "Edge.", this.Edge);
            this.SetParamObj(map, prefix + "InnerEcho.", this.InnerEcho);
            this.SetParamObj(map, prefix + "RearEcho.", this.RearEcho);
            this.SetParamObj(map, prefix + "Elastic.", this.Elastic);
            this.SetParamObj(map, prefix + "Shape.", this.Shape);
            this.SetParamObj(map, prefix + "ShapeAttr.", this.ShapeAttr);
            this.SetParamObj(map, prefix + "SkinMedulla.", this.SkinMedulla);
            this.SetParamObj(map, prefix + "Trend.", this.Trend);
            this.SetParamObj(map, prefix + "Calcification.", this.Calcification);
            this.SetParamObj(map, prefix + "Envelope.", this.Envelope);
            this.SetParamObj(map, prefix + "Enhancement.", this.Enhancement);
            this.SetParamObj(map, prefix + "LymphEnlargement.", this.LymphEnlargement);
            this.SetParamObj(map, prefix + "LymphDoor.", this.LymphDoor);
            this.SetParamObj(map, prefix + "Activity.", this.Activity);
            this.SetParamObj(map, prefix + "Operation.", this.Operation);
            this.SetParamObj(map, prefix + "CDFI.", this.CDFI);
            this.SetParamArraySimple(map, prefix + "Index.", this.Index);
            this.SetParamObj(map, prefix + "SizeStatus.", this.SizeStatus);
            this.SetParamObj(map, prefix + "InnerEchoDistribution.", this.InnerEchoDistribution);
            this.SetParamArrayObj(map, prefix + "InnerEchoType.", this.InnerEchoType);
            this.SetParamObj(map, prefix + "Outline.", this.Outline);
            this.SetParamObj(map, prefix + "Structure.", this.Structure);
            this.SetParamObj(map, prefix + "Density.", this.Density);
            this.SetParamObj(map, prefix + "Vas.", this.Vas);
            this.SetParamObj(map, prefix + "Cysticwall.", this.Cysticwall);
            this.SetParamObj(map, prefix + "Capsule.", this.Capsule);
            this.SetParamObj(map, prefix + "IsthmusThicknese.", this.IsthmusThicknese);
            this.SetParamSimple(map, prefix + "Src", this.Src);
        }
    }
}
