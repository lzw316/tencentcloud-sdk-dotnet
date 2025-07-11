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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OperationOpsDto : AbstractModel
    {
        
        /// <summary>
        /// 操作是否成功
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Result")]
        public bool? Result{ get; set; }

        /// <summary>
        /// 操作结果详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResultMsg")]
        public string ResultMsg{ get; set; }

        /// <summary>
        /// 操作失败类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorId")]
        public string ErrorId{ get; set; }

        /// <summary>
        /// 操作失败描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorDesc")]
        public string ErrorDesc{ get; set; }

        /// <summary>
        /// 异步操作记录id
        /// </summary>
        [JsonProperty("AsyncActionId")]
        public string AsyncActionId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamSimple(map, prefix + "ResultMsg", this.ResultMsg);
            this.SetParamSimple(map, prefix + "ErrorId", this.ErrorId);
            this.SetParamSimple(map, prefix + "ErrorDesc", this.ErrorDesc);
            this.SetParamSimple(map, prefix + "AsyncActionId", this.AsyncActionId);
        }
    }
}

