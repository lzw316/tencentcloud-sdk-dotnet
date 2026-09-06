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

namespace TencentCloud.Iotvideoindustry.V20201201.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecordTaskItem : AbstractModel
    {
        
        /// <summary>
        /// <p>录像任务ID</p>
        /// </summary>
        [JsonProperty("RecordTaskId")]
        public string RecordTaskId{ get; set; }

        /// <summary>
        /// <p>录制计划ID</p>
        /// </summary>
        [JsonProperty("RecordPlanId")]
        public string RecordPlanId{ get; set; }

        /// <summary>
        /// <p>本录制片段开始时间</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// <p>本录制片段结束时间</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// <p>录制模式</p>
        /// </summary>
        [JsonProperty("EventId")]
        public long? EventId{ get; set; }

        /// <summary>
        /// <p>本录制片段对应的录制文件URL</p>
        /// </summary>
        [JsonProperty("VideoUrl")]
        public string VideoUrl{ get; set; }

        /// <summary>
        /// <p>本录制片段当前的录制状态</p>
        /// </summary>
        [JsonProperty("RecordStatus")]
        public long? RecordStatus{ get; set; }

        /// <summary>
        /// <p>场景ID</p>
        /// </summary>
        [JsonProperty("SceneId")]
        public long? SceneId{ get; set; }

        /// <summary>
        /// <p>告警ID</p>
        /// </summary>
        [JsonProperty("WarnId")]
        public long? WarnId{ get; set; }

        /// <summary>
        /// <p>录制id，NVR下属设备有效</p>
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// <p>视频自增ID</p>
        /// </summary>
        [JsonProperty("InitID")]
        public long? InitID{ get; set; }

        /// <summary>
        /// <p>过期时间</p>
        /// </summary>
        [JsonProperty("ExpectDeleteTime")]
        public long? ExpectDeleteTime{ get; set; }

        /// <summary>
        /// <p>录制时长</p>
        /// </summary>
        [JsonProperty("RecordTimeLen")]
        public long? RecordTimeLen{ get; set; }

        /// <summary>
        /// <p>文件大小</p>
        /// </summary>
        [JsonProperty("FileSize")]
        public long? FileSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RecordTaskId", this.RecordTaskId);
            this.SetParamSimple(map, prefix + "RecordPlanId", this.RecordPlanId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
            this.SetParamSimple(map, prefix + "VideoUrl", this.VideoUrl);
            this.SetParamSimple(map, prefix + "RecordStatus", this.RecordStatus);
            this.SetParamSimple(map, prefix + "SceneId", this.SceneId);
            this.SetParamSimple(map, prefix + "WarnId", this.WarnId);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "InitID", this.InitID);
            this.SetParamSimple(map, prefix + "ExpectDeleteTime", this.ExpectDeleteTime);
            this.SetParamSimple(map, prefix + "RecordTimeLen", this.RecordTimeLen);
            this.SetParamSimple(map, prefix + "FileSize", this.FileSize);
        }
    }
}

