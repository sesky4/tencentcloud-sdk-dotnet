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

namespace TencentCloud.Gs.V20191118.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AndroidApp : AbstractModel
    {
        
        /// <summary>
        /// 安卓应用 Id
        /// </summary>
        [JsonProperty("AndroidAppId")]
        public string AndroidAppId{ get; set; }

        /// <summary>
        /// 安卓应用名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 安卓应用状态（上架、下架）
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 安卓应用版本列表
        /// </summary>
        [JsonProperty("AndroidAppVersionInfo")]
        public AndroidAppVersionInfo[] AndroidAppVersionInfo{ get; set; }

        /// <summary>
        /// 安卓应用创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 用户 Id
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 应用模式（NORMAL : 普通模式；ADVANCED : 高级模式）
        /// </summary>
        [JsonProperty("AppMode")]
        public string AppMode{ get; set; }

        /// <summary>
        /// 应用更新状态，取值：UPLOADING 上传中、CREATING 创建中、CREATE_FAIL 创建失败、CREATE_SUCCESS 创建成功、NORMAL 默认状态
        /// </summary>
        [JsonProperty("UpdateState")]
        public string UpdateState{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AndroidAppId", this.AndroidAppId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamArrayObj(map, prefix + "AndroidAppVersionInfo.", this.AndroidAppVersionInfo);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "AppMode", this.AppMode);
            this.SetParamSimple(map, prefix + "UpdateState", this.UpdateState);
        }
    }
}

