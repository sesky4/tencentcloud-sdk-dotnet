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

namespace TencentCloud.Vclm.V20240523.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubmitImageAnimateJobRequest : AbstractModel
    {
        
        /// <summary>
        /// 图片格式：支持PNG、JPG、JPEG、BMP、WEBP格式；
        /// 图片分辨率：长边分辨率范围【192，4096】；
        /// 图片大小：不超过10M；
        /// 图片宽高比：【宽：高】数值在 1:2 到 1:1.2 范围内
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// 图片base64数据。
        /// 图片格式：支持PNG、JPG、JPEG、BMP、WEBP格式；
        /// 图片分辨率：长边分辨率范围【192，4096】；
        /// 图片大小：不超过10M；
        /// 图片宽高比：【宽：高】数值在 1:2 到 1:1.2 范围内
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// 动作模板ID。取值说明：ke3 科目三；tuziwu 兔子舞；huajiangwu 划桨舞。
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// 结果视频是否保留模板音频。默认为true
        /// </summary>
        [JsonProperty("EnableAudio")]
        public bool? EnableAudio{ get; set; }

        /// <summary>
        /// 是否检测输入图人体12个身体部位（头部、颈部、右肩、右肘、右腕、左肩、左肘、左腕、右髋、左髋,、左膝、右膝）。默认不检测。
        /// </summary>
        [JsonProperty("EnableBodyJoins")]
        public bool? EnableBodyJoins{ get; set; }

        /// <summary>
        /// 是否对结果视频背景进行分割，默认值为false。
        /// true：分割结果视频，结果视频（ResultVideoUrl）将为去除背景的绿幕视频，并返回掩码视频（MaskVideoUrl）；
        /// false：不分割结果视频，结果视频（ResultVideoUrl）为带背景的视频，掩码视频（MaskVideoUrl）为空字符串。
        /// </summary>
        [JsonProperty("EnableSegment")]
        public bool? EnableSegment{ get; set; }

        /// <summary>
        /// 为生成视频添加标识的开关，默认为0。
        /// 1：添加标识。
        /// 0：不添加标识。
        /// 其他数值：默认按1处理。
        /// 建议您使用显著标识来提示，该视频是 AI 生成的视频。
        /// </summary>
        [JsonProperty("LogoAdd")]
        public long? LogoAdd{ get; set; }

        /// <summary>
        /// 标识内容设置。
        /// 默认在生成视频的右下角添加“视频由 AI 生成”字样，您可根据自身需要替换为其他的标识图片。
        /// </summary>
        [JsonProperty("LogoParam")]
        public LogoParam LogoParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "EnableAudio", this.EnableAudio);
            this.SetParamSimple(map, prefix + "EnableBodyJoins", this.EnableBodyJoins);
            this.SetParamSimple(map, prefix + "EnableSegment", this.EnableSegment);
            this.SetParamSimple(map, prefix + "LogoAdd", this.LogoAdd);
            this.SetParamObj(map, prefix + "LogoParam.", this.LogoParam);
        }
    }
}

