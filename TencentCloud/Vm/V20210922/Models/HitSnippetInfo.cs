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

    public class HitSnippetInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>命中内容</p>
        /// </summary>
        [JsonProperty("Target")]
        public string Target{ get; set; }

        /// <summary>
        /// <p>文本命中的文本块</p>
        /// </summary>
        [JsonProperty("Snippet")]
        public string Snippet{ get; set; }

        /// <summary>
        /// <p>命中场景</p>
        /// </summary>
        [JsonProperty("Scene")]
        public string Scene{ get; set; }

        /// <summary>
        /// <p>命中类型</p>
        /// </summary>
        [JsonProperty("AtomicCategory")]
        public string AtomicCategory{ get; set; }

        /// <summary>
        /// <p>命中类型库/模型名称</p>
        /// </summary>
        [JsonProperty("AtomicName")]
        public string AtomicName{ get; set; }

        /// <summary>
        /// <p>命中原子能力</p>
        /// </summary>
        [JsonProperty("AtomicId")]
        public string AtomicId{ get; set; }

        /// <summary>
        /// <p>命中单位</p>
        /// </summary>
        [JsonProperty("UnitId")]
        public string UnitId{ get; set; }

        /// <summary>
        /// <p>命中单位名称</p>
        /// </summary>
        [JsonProperty("UnitName")]
        public string UnitName{ get; set; }

        /// <summary>
        /// <p>命中颗粒ID</p>
        /// </summary>
        [JsonProperty("ParticleId")]
        public string ParticleId{ get; set; }

        /// <summary>
        /// <p>命中文本在原文起始位置</p>
        /// </summary>
        [JsonProperty("Positions")]
        public Position[] Positions{ get; set; }

        /// <summary>
        /// <p>命中图片框位置</p>
        /// </summary>
        [JsonProperty("Rect")]
        public Rect Rect{ get; set; }

        /// <summary>
        /// <p>命中音时间位置</p>
        /// </summary>
        [JsonProperty("Duration")]
        public Duration Duration{ get; set; }

        /// <summary>
        /// <p>分数</p>
        /// </summary>
        [JsonProperty("Score")]
        public long? Score{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Target", this.Target);
            this.SetParamSimple(map, prefix + "Snippet", this.Snippet);
            this.SetParamSimple(map, prefix + "Scene", this.Scene);
            this.SetParamSimple(map, prefix + "AtomicCategory", this.AtomicCategory);
            this.SetParamSimple(map, prefix + "AtomicName", this.AtomicName);
            this.SetParamSimple(map, prefix + "AtomicId", this.AtomicId);
            this.SetParamSimple(map, prefix + "UnitId", this.UnitId);
            this.SetParamSimple(map, prefix + "UnitName", this.UnitName);
            this.SetParamSimple(map, prefix + "ParticleId", this.ParticleId);
            this.SetParamArrayObj(map, prefix + "Positions.", this.Positions);
            this.SetParamObj(map, prefix + "Rect.", this.Rect);
            this.SetParamObj(map, prefix + "Duration.", this.Duration);
            this.SetParamSimple(map, prefix + "Score", this.Score);
        }
    }
}

