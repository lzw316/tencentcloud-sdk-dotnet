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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OpenMem0ServiceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例ID</p>
        /// </summary>
        [JsonProperty("DBInstanceId")]
        public string DBInstanceId{ get; set; }

        /// <summary>
        /// <p>AgenticBaseID，开启Mem0服务前请先开通AgenticBase套餐</p>
        /// </summary>
        [JsonProperty("AgenticBaseId")]
        public string AgenticBaseId{ get; set; }

        /// <summary>
        /// <p>Mem0服务使用的LLM模型</p><p>枚举值：</p><ul><li>auto： 自动选择合适的模型</li><li>deepseek-v4-flash： deepseek-v4-flash</li><li>deepseek-v4-pro： deepseek-v4-pro</li><li>glm-5： glm-5</li><li>glm-5-turbo： glm-5-turbo</li><li>glm-5.1： glm-5.1</li><li>kimi-k2.5： kimi-k2.5</li><li>kimi-k2.6： kimi-k2.6</li><li>minimax-m2.5： minimax-m2.5</li><li>minimax-m2.7： minimax-m2.7</li></ul>
        /// </summary>
        [JsonProperty("LLMModel")]
        public string LLMModel{ get; set; }

        /// <summary>
        /// <p>请前往腾讯云Tokenhub开通服务将ApiKey填入</p>
        /// </summary>
        [JsonProperty("EmbeddingApiKey")]
        public string EmbeddingApiKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DBInstanceId", this.DBInstanceId);
            this.SetParamSimple(map, prefix + "AgenticBaseId", this.AgenticBaseId);
            this.SetParamSimple(map, prefix + "LLMModel", this.LLMModel);
            this.SetParamSimple(map, prefix + "EmbeddingApiKey", this.EmbeddingApiKey);
        }
    }
}

