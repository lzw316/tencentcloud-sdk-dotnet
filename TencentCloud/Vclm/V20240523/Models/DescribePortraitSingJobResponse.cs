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

namespace TencentCloud.Vclm.V20240523.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePortraitSingJobResponse : AbstractModel
    {
        
        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// 任务状态码
        /// —RUN：处理中
        /// —FAIL：处理失败
        /// —STOP：处理终止
        /// —DONE：处理完成
        /// </summary>
        [JsonProperty("StatusCode")]
        public string StatusCode{ get; set; }

        /// <summary>
        /// 任务状态信息
        /// </summary>
        [JsonProperty("StatusMsg")]
        public string StatusMsg{ get; set; }

        /// <summary>
        /// 任务执行错误码。当任务状态不为FAIL时，该值为""。
        /// </summary>
        [JsonProperty("ErrorCode")]
        public string ErrorCode{ get; set; }

        /// <summary>
        /// 任务执行错误信息。当任务状态不为FAIL时，该值为""。
        /// </summary>
        [JsonProperty("ErrorMessage")]
        public string ErrorMessage{ get; set; }

        /// <summary>
        /// 生成视频的URL地址。有效期24小时。
        /// </summary>
        [JsonProperty("ResultVideoUrl")]
        public string ResultVideoUrl{ get; set; }

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
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "StatusCode", this.StatusCode);
            this.SetParamSimple(map, prefix + "StatusMsg", this.StatusMsg);
            this.SetParamSimple(map, prefix + "ErrorCode", this.ErrorCode);
            this.SetParamSimple(map, prefix + "ErrorMessage", this.ErrorMessage);
            this.SetParamSimple(map, prefix + "ResultVideoUrl", this.ResultVideoUrl);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

