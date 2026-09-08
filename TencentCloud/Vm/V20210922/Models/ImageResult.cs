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

namespace TencentCloud.Vm.V20210922.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageResult : AbstractModel
    {
        
        /// <summary>
        /// <p>违规标志<br>0 未命中<br>1 命中</p>
        /// </summary>
        [JsonProperty("HitFlag")]
        public long? HitFlag{ get; set; }

        /// <summary>
        /// <p>命中的标签<br>Porn 色情<br>Sexy 性感<br>Polity 政治<br>Illegal 违法<br>Abuse 谩骂<br>Terror 暴恐<br>Ad 广告</p>
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// <p>审核建议，可选值：<br>Pass 通过，<br>Review 建议人审，<br>Block 确认违规</p>
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// <p>得分</p>
        /// </summary>
        [JsonProperty("Score")]
        public long? Score{ get; set; }

        /// <summary>
        /// <p>画面截帧图片结果集</p>
        /// </summary>
        [JsonProperty("Results")]
        public ImageResultResult[] Results{ get; set; }

        /// <summary>
        /// <p>该字段用于返回审核结果的访问链接（URL）。<br>备注：链接默认有效期为12小时。如果您需要更长时效的链接，请使用<a href="https://cloud.tencent.com/document/product/1265/104001">COS预签名</a>功能更新签名时效。</p>
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// <p>附加字段</p>
        /// </summary>
        [JsonProperty("Extra")]
        public string Extra{ get; set; }

        /// <summary>
        /// <p>二级标签</p>
        /// </summary>
        [JsonProperty("SubLabel")]
        public string SubLabel{ get; set; }

        /// <summary>
        /// <p>场景结果</p>
        /// </summary>
        [JsonProperty("RecognitionResults")]
        public RecognitionResult[] RecognitionResults{ get; set; }

        /// <summary>
        /// <p>审核命中类型</p>
        /// </summary>
        [JsonProperty("HitType")]
        public string HitType{ get; set; }

        /// <summary>
        /// <p>截帧请求ID</p>
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }

        /// <summary>
        /// <p>命中信息</p>
        /// </summary>
        [JsonProperty("HitSnippetInfos")]
        public HitSnippetInfo[] HitSnippetInfos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HitFlag", this.HitFlag);
            this.SetParamSimple(map, prefix + "Label", this.Label);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamArrayObj(map, prefix + "Results.", this.Results);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Extra", this.Extra);
            this.SetParamSimple(map, prefix + "SubLabel", this.SubLabel);
            this.SetParamArrayObj(map, prefix + "RecognitionResults.", this.RecognitionResults);
            this.SetParamSimple(map, prefix + "HitType", this.HitType);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
            this.SetParamArrayObj(map, prefix + "HitSnippetInfos.", this.HitSnippetInfos);
        }
    }
}

