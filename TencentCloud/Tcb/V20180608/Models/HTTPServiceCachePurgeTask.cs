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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HTTPServiceCachePurgeTask : AbstractModel
    {
        
        /// <summary>
        /// <p>缓存类型</p><p>枚举值：</p><ul><li>EO： EO</li><li>TCBCDN： 云开发cdn</li></ul><p>默认值：EO</p>
        /// </summary>
        [JsonProperty("CacheType")]
        public string CacheType{ get; set; }

        /// <summary>
        /// <p>任务id</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>状态</p><p>枚举值：</p><ul><li>PROCESSING： 处理中</li><li>SUCCESS： 成功</li><li>FAILED： 失败</li><li>TIMEOUT： 超时</li><li>CANCELED： 取消</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>刷新类型</p><p>枚举值：</p><ul><li>PURGE_URL： URL 刷新</li><li>PURGE_PREFIX： 目录刷新</li><li>PURGE_HOST： Hostname 刷新</li></ul>
        /// </summary>
        [JsonProperty("PurgeType")]
        public string PurgeType{ get; set; }

        /// <summary>
        /// <p>清除缓存分为直接删除和标记过期两种方式。URL 类型默认为“直接删除”，其它清除类型默认为“标记过期”</p><p>枚举值：</p><ul><li>INVALIDATE： 标记过期：节点缓存标记为过期，用户请求时回源校验，源站 304 则复用，200 则更新</li><li>DELETE： 直接删除：从节点直接删除缓存，用户下次请求强制回源拉新</li></ul>
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// <p>刷新目标列表（URL / 前缀 / host）</p>
        /// </summary>
        [JsonProperty("Targets")]
        public string[] Targets{ get; set; }

        /// <summary>
        /// <p>失败原因</p>
        /// </summary>
        [JsonProperty("FailReason")]
        public string FailReason{ get; set; }

        /// <summary>
        /// <p>任务创建时间</p><p>参数格式：格式 YYYY-MM-DDTHH:mm:ss±HH:mmZ，时区为 UTC+0</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>任务更新时间</p><p>参数格式：格式 YYYY-MM-DDTHH:mm:ss±HH:mmZ，时区为 UTC+0</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CacheType", this.CacheType);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "PurgeType", this.PurgeType);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamArraySimple(map, prefix + "Targets.", this.Targets);
            this.SetParamSimple(map, prefix + "FailReason", this.FailReason);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

