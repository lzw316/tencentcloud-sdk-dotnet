/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AIDubbingTaskInput : AbstractModel
    {
        
        /// <summary>
        /// <p>AI配音模板id。</p>
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// <p>AI配音自定义参数，当 Definition 填 0 时有效。 该参数用于高度定制场景，建议您优先使用 Definition 指定配音参数。</p>
        /// </summary>
        [JsonProperty("RawParameter")]
        public RawAIDubbingParameter RawParameter{ get; set; }

        /// <summary>
        /// <p>AI配音自定义参数，当 Definition 不填 0 时有效。 当填写了该结构中的部分配音参数时，将使用填写的参数覆盖AI配音模板中的参数。 该参数用于高度定制场景，建议您仅使用 Definition 指定配音参数。</p>
        /// </summary>
        [JsonProperty("OverrideParameter")]
        public OverrideAIDubbingParameter OverrideParameter{ get; set; }

        /// <summary>
        /// <p>文件的目标存储，不填则继承上层的 OutputStorage 值。</p>
        /// </summary>
        [JsonProperty("OutputStorage")]
        public TaskOutputStorage OutputStorage{ get; set; }

        /// <summary>
        /// <p>外部源字幕文件信息。</p>
        /// </summary>
        [JsonProperty("SrcSubtitleInfo")]
        public MediaInputInfo SrcSubtitleInfo{ get; set; }

        /// <summary>
        /// <p>外部字幕文件信息，译文字幕。</p>
        /// </summary>
        [JsonProperty("DstSubtitleInfos")]
        public DstSubtitleInput[] DstSubtitleInfos{ get; set; }

        /// <summary>
        /// <p>文件的输出路径，可以为相对路径或者绝对路径。<br>若需定义输出路径，路径需以<code>.{format}</code>结尾。变量名请参考 <a href="https://cloud.tencent.com/document/product/862/37039">文件名变量说明</a>。<br>相对路径示例：</p><li>文件名_{变量名}.{format}</li><li>文件名.{format}</li>绝对路径示例：<li>/自定义路径/文件名_{变量名}.{format}</li><p><strong>注意</strong>：目前不支持<code>BatchProcessMedia</code>接口。</p>
        /// </summary>
        [JsonProperty("OutputObjectPath")]
        public string OutputObjectPath{ get; set; }

        /// <summary>
        /// <p>AI配音扩展参数，序列化的 json 字符串。</p>
        /// </summary>
        [JsonProperty("ExtendedParameter")]
        public string ExtendedParameter{ get; set; }

        /// <summary>
        /// <p>关联剧集ID。<br>注意：配音模式为按角色智能配音时此值生效。</p>
        /// </summary>
        [JsonProperty("DramaId")]
        public string DramaId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamObj(map, prefix + "RawParameter.", this.RawParameter);
            this.SetParamObj(map, prefix + "OverrideParameter.", this.OverrideParameter);
            this.SetParamObj(map, prefix + "OutputStorage.", this.OutputStorage);
            this.SetParamObj(map, prefix + "SrcSubtitleInfo.", this.SrcSubtitleInfo);
            this.SetParamArrayObj(map, prefix + "DstSubtitleInfos.", this.DstSubtitleInfos);
            this.SetParamSimple(map, prefix + "OutputObjectPath", this.OutputObjectPath);
            this.SetParamSimple(map, prefix + "ExtendedParameter", this.ExtendedParameter);
            this.SetParamSimple(map, prefix + "DramaId", this.DramaId);
        }
    }
}

