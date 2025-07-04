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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StaffInfo : AbstractModel
    {
        
        /// <summary>
        /// 座席名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 座席邮箱
        /// </summary>
        [JsonProperty("Mail")]
        public string Mail{ get; set; }

        /// <summary>
        /// 座席电话号码
        /// </summary>
        [JsonProperty("Phone")]
        public string Phone{ get; set; }

        /// <summary>
        /// 座席昵称
        /// </summary>
        [JsonProperty("Nick")]
        public string Nick{ get; set; }

        /// <summary>
        /// 座席工号
        /// </summary>
        [JsonProperty("StaffNumber")]
        public string StaffNumber{ get; set; }

        /// <summary>
        /// 用户角色 ID，一个用户绑定了多个角色时以RoleIdList为准
        /// </summary>
        [JsonProperty("RoleId")]
        [System.Obsolete]
        public ulong? RoleId{ get; set; }

        /// <summary>
        /// 用户角色id列表
        /// </summary>
        [JsonProperty("RoleIdList")]
        [System.Obsolete]
        public ulong? RoleIdList{ get; set; }

        /// <summary>
        /// 用户角色id列表
        /// </summary>
        [JsonProperty("RoleList")]
        public ulong?[] RoleList{ get; set; }

        /// <summary>
        /// 所属技能组列表
        /// </summary>
        [JsonProperty("SkillGroupList")]
        public SkillGroupItem[] SkillGroupList{ get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [JsonProperty("LastModifyTimestamp")]
        public long? LastModifyTimestamp{ get; set; }

        /// <summary>
        /// 座席分机号（1 到 8 打头，4 - 6 位）
        /// </summary>
        [JsonProperty("ExtensionNumber")]
        public string ExtensionNumber{ get; set; }

        /// <summary>
        /// 呼叫转移配置
        /// </summary>
        [JsonProperty("ForwardingConfig")]
        public ForwardingConfig ForwardingConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Mail", this.Mail);
            this.SetParamSimple(map, prefix + "Phone", this.Phone);
            this.SetParamSimple(map, prefix + "Nick", this.Nick);
            this.SetParamSimple(map, prefix + "StaffNumber", this.StaffNumber);
            this.SetParamSimple(map, prefix + "RoleId", this.RoleId);
            this.SetParamSimple(map, prefix + "RoleIdList", this.RoleIdList);
            this.SetParamArraySimple(map, prefix + "RoleList.", this.RoleList);
            this.SetParamArrayObj(map, prefix + "SkillGroupList.", this.SkillGroupList);
            this.SetParamSimple(map, prefix + "LastModifyTimestamp", this.LastModifyTimestamp);
            this.SetParamSimple(map, prefix + "ExtensionNumber", this.ExtensionNumber);
            this.SetParamObj(map, prefix + "ForwardingConfig.", this.ForwardingConfig);
        }
    }
}

