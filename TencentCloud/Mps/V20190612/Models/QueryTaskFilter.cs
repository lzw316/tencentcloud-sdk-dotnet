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

    public class QueryTaskFilter : AbstractModel
    {
        
        /// <summary>
        /// <p>任务ID</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>任务类型</p><p>枚举值：</p><ul><li>RedrawVideo： 视频重绘</li><li>AIDrama： AI漫剧</li><li>DocGenVideo： 文档生视频</li><li>FissionVideo： 视频裂变</li></ul>
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// <p>任务状态</p>
        /// </summary>
        [JsonProperty("TaskStatus")]
        public string TaskStatus{ get; set; }

        /// <summary>
        /// <p>分辨率</p>
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }

        /// <summary>
        /// <p>宽高比</p>
        /// </summary>
        [JsonProperty("Ratio")]
        public string Ratio{ get; set; }

        /// <summary>
        /// <p>任务执行模式</p><p>枚举值：</p><ul><li>auto： 直接生成</li><li>phased： 确认后再生成</li></ul>
        /// </summary>
        [JsonProperty("ExecuteMode")]
        public string ExecuteMode{ get; set; }

        /// <summary>
        /// <p>裂变任务视频类型过滤: ugc、talk、display、unboxing、reaction</p><p>枚举值：</p><ul><li>ugc： UGC种草</li><li>talk： 产品口播</li><li>display： 产品展示</li><li>unboxing： 开箱分享</li><li>reaction： 反应展示</li></ul>
        /// </summary>
        [JsonProperty("VideoType")]
        public string VideoType{ get; set; }

        /// <summary>
        /// <p>模型类型</p><p>枚举值：</p><ul><li>standard： 标准版</li><li>flagship： 高级版</li></ul>
        /// </summary>
        [JsonProperty("ModelTier")]
        public string ModelTier{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
            this.SetParamSimple(map, prefix + "Ratio", this.Ratio);
            this.SetParamSimple(map, prefix + "ExecuteMode", this.ExecuteMode);
            this.SetParamSimple(map, prefix + "VideoType", this.VideoType);
            this.SetParamSimple(map, prefix + "ModelTier", this.ModelTier);
        }
    }
}

