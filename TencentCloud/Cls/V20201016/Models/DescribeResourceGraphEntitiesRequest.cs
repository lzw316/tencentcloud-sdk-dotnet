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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeResourceGraphEntitiesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>资源图谱id</p>
        /// </summary>
        [JsonProperty("ResourceGraphId")]
        public string ResourceGraphId{ get; set; }

        /// <summary>
        /// <ul><li>Product 按【产品分组】精确匹配，可用参数：all / business_service / tke / cdb / redis / mongodb 。类型：String。必选：否</li><li>EntityClassName 按【实体类型】精确匹配，可用参数：all / app.service.application / tc.tke.cluster / tc.tkex.project / tc.cdb.instance / tc.redis.instance / tc.mongodb.instance / k8s.cluster / k8s.namespace / k8s.node / k8s.pod / k8s.ip / k8s.service / k8s.deployment / k8s.statefulset / k8s.statefulsetplus / k8s.daemonset / k8s.storageclass / k8s.persistentvolume / k8s.persistentvolumeclaim / k8s.secret。类型：String。必选：否</li><li>Name 按【实体名称】模糊匹配。类型：String。必选：否</li><li>ResourceId 按 【实体资源id】精确匹配。类型：String。必选：否</li></ul><p>注意：每次请求的 Filters 上限 10。</p>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// <p>查询偏移</p>
        /// </summary>
        [JsonProperty("NextCursor")]
        public string NextCursor{ get; set; }

        /// <summary>
        /// <p>分页单页数量，默认 20，最大 100</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>查询开始时间</p><p>单位：毫秒</p>
        /// </summary>
        [JsonProperty("FromTime")]
        public ulong? FromTime{ get; set; }

        /// <summary>
        /// <p>查询结束时间</p><p>单位：毫秒</p>
        /// </summary>
        [JsonProperty("ToTime")]
        public ulong? ToTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceGraphId", this.ResourceGraphId);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "NextCursor", this.NextCursor);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "FromTime", this.FromTime);
            this.SetParamSimple(map, prefix + "ToTime", this.ToTime);
        }
    }
}

