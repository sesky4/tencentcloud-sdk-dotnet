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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RequestFieldsForException : AbstractModel
    {
        
        /// <summary>
        /// 跳过的具体字段。取值支持：<br/>
        /// <li>body.json：JSON 请求内容；此时 Condition 支持 key、value,  TargetField 支持 key、value，例如 { "Scope": "body.json",  "Condition": "", "TargetField": "key" }，表示 JSON 请求内容所有参数跳过 WAF 扫描；</li>
        /// <li style="margin-top:5px">cookie：Cookie；此时 Condition 支持 key、value,  TargetField 支持 key、value，例如 { "Scope": "cookie",  "Condition": "${key} in ['account-id'] and ${value} like ['prefix-*']", "TargetField": "value" }，表示 Cookie 参数名称等于account-id 并且参数值通配符匹配 prefix-* 跳过 WAF 扫描；</li>
        /// <li style="margin-top:5px">header：HTTP 头部参数；此时 Condition 支持 key、value,  TargetField 支持 key、value，例如 { "Scope": "header",  "Condition": "${key} like ['x-auth-*']", "TargetField": "value" }，表示 header 参数名称通配符匹配 x-auth-* 跳过 WAF 扫描；</li>
        /// <li style="margin-top:5px">uri.query：URL 编码内容/查询参数；此时 Condition 支持 key、value,  TargetField 支持 key、value，例如 { "Scope": "uri.query",  "Condition": "${key} in ['action'] and ${value} in ['upload', 'delete']", "TargetField": "value" }，表示 URL 编码内容/查询参数的参数名称等于 action 并且参数值等于 upload 或 delete 跳过 WAF 扫描；</li>
        /// <li style="margin-top:5px">uri：请求路径URI；此时 Condition 必须为空， TargetField 支持 query、path、fullpath，例如 { "Scope": "uri",  "Condition": "", "TargetField": "query" }，表示请求路径 URI 仅查询参数跳过 WAF 扫描；</li>
        /// <li style="margin-top:5px">body：请求正文内容。此时 Condition 必须为空， TargetField 支持 fullbody、multipart，例如 { "Scope": "body",  "Condition": "", "TargetField": "fullbody" }，表示请求正文内容为完整请求正文跳过 WAF 扫描；</li>
        /// </summary>
        [JsonProperty("Scope")]
        public string Scope{ get; set; }

        /// <summary>
        /// 跳过的具体字段的表达式，需要符合表达式语法。<br />
        /// Condition  支持表达式配置语法：<li> 按规则的匹配条件表达式语法编写，支持引用 key、value。</li><li> 支持 in、like 操作符，以及 and 逻辑组合。</li>
        /// 例如：<li>${key} in ['x-trace-id']：参数名称等于x-trace-id。</li><li>${key} in ['x-trace-id'] and ${value} like ['Bearer *']：参数名称等于x-trace-id并且参数值通配符匹配Bearer *。</li>
        /// </summary>
        [JsonProperty("Condition")]
        public string Condition{ get; set; }

        /// <summary>
        /// Scope 参数使用不同取值时，TargetField 表达式中支持的值如下：
        /// <li> body.json：支持 key、value</li>
        /// <li> cookie：支持 key、value</li>
        /// <li> header：支持 key、value</li>
        /// <li> uri.query：支持 key、value</li>
        /// <li> uri：支持 path、query、fullpath</li>
        /// <li> body：支持 fullbody、multipart</li>
        /// </summary>
        [JsonProperty("TargetField")]
        public string TargetField{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
            this.SetParamSimple(map, prefix + "Condition", this.Condition);
            this.SetParamSimple(map, prefix + "TargetField", this.TargetField);
        }
    }
}

