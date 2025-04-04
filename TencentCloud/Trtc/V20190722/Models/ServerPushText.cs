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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServerPushText : AbstractModel
    {
        
        /// <summary>
        /// 服务端推送播报文本
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// 是否允许该文本打断机器人说话
        /// </summary>
        [JsonProperty("Interrupt")]
        public bool? Interrupt{ get; set; }

        /// <summary>
        /// 播报完文本后，是否自动关闭对话任务
        /// </summary>
        [JsonProperty("StopAfterPlay")]
        public bool? StopAfterPlay{ get; set; }

        /// <summary>
        /// 服务端推送播报音频
        ///     格式说明：音频以16KHz采样率的单声道格式提供，编码为Base64字符串。
        ///     输入规则：当提供Audio字段时，将不接受Text字段的输入。系统将直接播放Audio字段中的音频内容。
        /// </summary>
        [JsonProperty("Audio")]
        public string Audio{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "Interrupt", this.Interrupt);
            this.SetParamSimple(map, prefix + "StopAfterPlay", this.StopAfterPlay);
            this.SetParamSimple(map, prefix + "Audio", this.Audio);
        }
    }
}

