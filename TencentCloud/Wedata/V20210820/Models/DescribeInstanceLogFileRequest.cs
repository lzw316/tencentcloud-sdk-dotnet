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

    public class DescribeInstanceLogFileRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 实例数据时间
        /// </summary>
        [JsonProperty("CurRunDate")]
        public string CurRunDate{ get; set; }

        /// <summary>
        /// 请求来源，WEB 前端；CLIENT 客户端
        /// </summary>
        [JsonProperty("RequestFromSource")]
        public string RequestFromSource{ get; set; }

        /// <summary>
        /// 执行机IP
        /// </summary>
        [JsonProperty("BrokerIp")]
        public string BrokerIp{ get; set; }

        /// <summary>
        /// 日志文件名
        /// </summary>
        [JsonProperty("OriginFileName")]
        public string OriginFileName{ get; set; }

        /// <summary>
        /// 执行平台下发执行id
        /// </summary>
        [JsonProperty("ExecutionJobId")]
        public string ExecutionJobId{ get; set; }

        /// <summary>
        /// 日志级别，Info/Debug/Warn/Error/All
        /// </summary>
        [JsonProperty("LogLevelType")]
        public string LogLevelType{ get; set; }

        /// <summary>
        /// 文件类型,Log/Code
        /// </summary>
        [JsonProperty("ExecutionFileType")]
        public string ExecutionFileType{ get; set; }

        /// <summary>
        /// 生命周期为基础数据进行日志匹配。Dynamic=true动态获取日志链路中使用
        /// </summary>
        [JsonProperty("InstanceLifeDetailDtoList")]
        public InstanceLifeDetailDto[] InstanceLifeDetailDtoList{ get; set; }

        /// <summary>
        /// 当前生命周期数
        /// </summary>
        [JsonProperty("CurrentLifeRound")]
        public long? CurrentLifeRound{ get; set; }

        /// <summary>
        /// 最大生命周期数
        /// </summary>
        [JsonProperty("MaxLifeRound")]
        public long? MaxLifeRound{ get; set; }

        /// <summary>
        /// 当前生命周期重试次数
        /// </summary>
        [JsonProperty("Tries")]
        public long? Tries{ get; set; }

        /// <summary>
        /// 动态获取日志信息标识
        /// </summary>
        [JsonProperty("Dynamic")]
        public bool? Dynamic{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "CurRunDate", this.CurRunDate);
            this.SetParamSimple(map, prefix + "RequestFromSource", this.RequestFromSource);
            this.SetParamSimple(map, prefix + "BrokerIp", this.BrokerIp);
            this.SetParamSimple(map, prefix + "OriginFileName", this.OriginFileName);
            this.SetParamSimple(map, prefix + "ExecutionJobId", this.ExecutionJobId);
            this.SetParamSimple(map, prefix + "LogLevelType", this.LogLevelType);
            this.SetParamSimple(map, prefix + "ExecutionFileType", this.ExecutionFileType);
            this.SetParamArrayObj(map, prefix + "InstanceLifeDetailDtoList.", this.InstanceLifeDetailDtoList);
            this.SetParamSimple(map, prefix + "CurrentLifeRound", this.CurrentLifeRound);
            this.SetParamSimple(map, prefix + "MaxLifeRound", this.MaxLifeRound);
            this.SetParamSimple(map, prefix + "Tries", this.Tries);
            this.SetParamSimple(map, prefix + "Dynamic", this.Dynamic);
        }
    }
}

