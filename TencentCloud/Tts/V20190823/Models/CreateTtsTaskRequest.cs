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

namespace TencentCloud.Tts.V20190823.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateTtsTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 合成语音的源文本，按UTF-8编码统一计算，最多支持10万字符
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// 模型类型，1-默认模型。
        /// </summary>
        [JsonProperty("ModelType")]
        public long? ModelType{ get; set; }

        /// <summary>
        /// 音量大小，范围：[0，10]，分别对应11个等级的音量，默认为0，代表正常音量。没有静音选项。
        /// 输入除以上整数之外的其他参数不生效，按默认值处理。
        /// </summary>
        [JsonProperty("Volume")]
        public float? Volume{ get; set; }

        /// <summary>
        /// 语速，范围：[-2，2]，分别对应不同语速：<li>-2代表0.6倍</li><li>-1代表0.8倍</li><li>0代表1.0倍（默认）</li><li>1代表1.2倍</li><li>2代表1.5倍</li>如果需要更细化的语速，可以保留小数点后一位，例如0.5 1.1 1.8等。<br>
        /// </summary>
        [JsonProperty("Speed")]
        public float? Speed{ get; set; }

        /// <summary>
        /// 项目id，用户自定义，默认为0。
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 标准音色<li>1001-智瑜，情感女声(默认)</li><li>1002-智聆，通用女声</li><li>1003-智美，客服女声</li><li>1006-智云，通用男声</li><li>1050-WeJack，英文男声</li><li>1051-WeRose，英文女声</li>精品音色<br>精品音色拟真度更高，价格不同于普通音色，查看[购买指南](https://cloud.tencent.com/product/tts/pricing)<br><li>101001-智瑜，情感女声（精品）</li><li>101002-智聆，通用女声（精品）</li><li>101003-智美，客服女声（精品）</li><li>101004-智云，通用男声</li><li>101005-智莉，通用女声</li><li>101006-智言，助手女声</li><li>101007-智娜，客服女声</li><li>101008-智琪，客服女声</li><li>101009-智芸，知性女声</li><li>101010-智华，通用男声</li><li>101011-智燕，新闻女声</li><li>101012-智丹，新闻女声</li><li>101013-智辉，新闻男声</li><li>101014-智宁，新闻男声</li><li>101015-智萌，男童声</li><li>101016-智甜，女童声</li><li>101017-智蓉，情感女声</li><li>101018-智靖，情感男声</li><li>101019-智彤，粤语女声</li><li>101050-WeJack，英文男声（精品）</li><li>101051-WeRose，英文女声（精品）</li>
        /// </summary>
        [JsonProperty("VoiceType")]
        public long? VoiceType{ get; set; }

        /// <summary>
        /// 主语言类型：<li>1-中文（默认）</li><li>2-英文</li>
        /// </summary>
        [JsonProperty("PrimaryLanguage")]
        public long? PrimaryLanguage{ get; set; }

        /// <summary>
        /// 音频采样率：<li>16000：16k（默认）</li><li>8000：8k</li>
        /// </summary>
        [JsonProperty("SampleRate")]
        public ulong? SampleRate{ get; set; }

        /// <summary>
        /// 返回音频格式，可取值：mp3（默认），wav，pcm
        /// </summary>
        [JsonProperty("Codec")]
        public string Codec{ get; set; }

        /// <summary>
        /// 回调 URL，用户自行搭建的用于接收识别结果的服务URL。如果用户使用轮询方式获取识别结果，则无需提交该参数。[回调说明](https://cloud.tencent.com/document/product/1073/55746)
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// 旁白与对白文本解析，分别合成相应风格（仅适用于旁对白音色），默认 false
        /// </summary>
        [JsonProperty("VoiceoverDialogueSplit")]
        public bool? VoiceoverDialogueSplit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "ModelType", this.ModelType);
            this.SetParamSimple(map, prefix + "Volume", this.Volume);
            this.SetParamSimple(map, prefix + "Speed", this.Speed);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "VoiceType", this.VoiceType);
            this.SetParamSimple(map, prefix + "PrimaryLanguage", this.PrimaryLanguage);
            this.SetParamSimple(map, prefix + "SampleRate", this.SampleRate);
            this.SetParamSimple(map, prefix + "Codec", this.Codec);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamSimple(map, prefix + "VoiceoverDialogueSplit", this.VoiceoverDialogueSplit);
        }
    }
}
