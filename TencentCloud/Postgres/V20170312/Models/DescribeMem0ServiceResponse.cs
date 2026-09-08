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

    public class DescribeMem0ServiceResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>mem0服务运行状态</p><p>枚举值：</p><ul><li>running： mem0服务正常运行</li><li>none： 未开通</li><li>creating： 正在开通</li><li>deleting： mem0服务关闭中</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Mem0服务创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Mem0服务最后更新时间</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>Mem0服务访问地址</p>
        /// </summary>
        [JsonProperty("InnerAddress")]
        public string InnerAddress{ get; set; }

        /// <summary>
        /// <p>Mem0服务使用的AgenticBase</p>
        /// </summary>
        [JsonProperty("AgenticBaseId")]
        public string AgenticBaseId{ get; set; }

        /// <summary>
        /// <p>Mem0服务使用的LLM提供方</p><p>枚举值：</p><ul><li>tokenhub： 腾讯云大模型服务平台TokenHub</li></ul>
        /// </summary>
        [JsonProperty("LLMMode")]
        public string LLMMode{ get; set; }

        /// <summary>
        /// <p>Mem0服务使用的LLM模型</p>
        /// </summary>
        [JsonProperty("LLMModel")]
        public string LLMModel{ get; set; }

        /// <summary>
        /// <p>Mem0服务当前使用的Embedding 模型</p>
        /// </summary>
        [JsonProperty("EmbeddingModel")]
        public string EmbeddingModel{ get; set; }

        /// <summary>
        /// <p>Embedding 向量维度，目前固定1024</p>
        /// </summary>
        [JsonProperty("EmbeddingDims")]
        public long? EmbeddingDims{ get; set; }

        /// <summary>
        /// <p>Mem0服务使用的PG数据库</p>
        /// </summary>
        [JsonProperty("PGDatabaseName")]
        public string PGDatabaseName{ get; set; }

        /// <summary>
        /// <p>Mem0服务使用的PG用户名</p>
        /// </summary>
        [JsonProperty("PGUserName")]
        public string PGUserName{ get; set; }

        /// <summary>
        /// <p>Mem0的网络状态</p>
        /// </summary>
        [JsonProperty("NetworkAccessList")]
        public DBInstanceNetInfo[] NetworkAccessList{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "InnerAddress", this.InnerAddress);
            this.SetParamSimple(map, prefix + "AgenticBaseId", this.AgenticBaseId);
            this.SetParamSimple(map, prefix + "LLMMode", this.LLMMode);
            this.SetParamSimple(map, prefix + "LLMModel", this.LLMModel);
            this.SetParamSimple(map, prefix + "EmbeddingModel", this.EmbeddingModel);
            this.SetParamSimple(map, prefix + "EmbeddingDims", this.EmbeddingDims);
            this.SetParamSimple(map, prefix + "PGDatabaseName", this.PGDatabaseName);
            this.SetParamSimple(map, prefix + "PGUserName", this.PGUserName);
            this.SetParamArrayObj(map, prefix + "NetworkAccessList.", this.NetworkAccessList);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

