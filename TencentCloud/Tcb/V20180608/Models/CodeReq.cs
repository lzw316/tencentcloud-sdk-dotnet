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

    public class CodeReq : AbstractModel
    {
        
        /// <summary>
        /// 包含函数代码的zip格式文件
        /// </summary>
        [JsonProperty("ZipFile")]
        public string ZipFile{ get; set; }

        /// <summary>
        /// 对象存储桶名称（填写存储桶名称自定义部分，不包含-appid）
        /// </summary>
        [JsonProperty("CosBucketName")]
        public string CosBucketName{ get; set; }

        /// <summary>
        /// 对象存储中代码包文件路径，以/开头
        /// </summary>
        [JsonProperty("CosObjectName")]
        public string CosObjectName{ get; set; }

        /// <summary>
        /// 对象存储的地域，地域为北京时需要传入ap-beijing,北京一区时需要传递ap-beijing-1，其他的地域不需要传递。
        /// </summary>
        [JsonProperty("CosBucketRegion")]
        public string CosBucketRegion{ get; set; }

        /// <summary>
        /// 如果是从TempCos创建的话，需要传入TempCosObjectName
        /// </summary>
        [JsonProperty("TempCosObjectName")]
        public string TempCosObjectName{ get; set; }

        /// <summary>
        /// 如果是通过Demo创建的话，需要传入DemoId
        /// </summary>
        [JsonProperty("DemoId")]
        public string DemoId{ get; set; }

        /// <summary>
        /// 上传云开发cos后返回的时间戳
        /// </summary>
        [JsonProperty("CosTimestamp")]
        public string CosTimestamp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZipFile", this.ZipFile);
            this.SetParamSimple(map, prefix + "CosBucketName", this.CosBucketName);
            this.SetParamSimple(map, prefix + "CosObjectName", this.CosObjectName);
            this.SetParamSimple(map, prefix + "CosBucketRegion", this.CosBucketRegion);
            this.SetParamSimple(map, prefix + "TempCosObjectName", this.TempCosObjectName);
            this.SetParamSimple(map, prefix + "DemoId", this.DemoId);
            this.SetParamSimple(map, prefix + "CosTimestamp", this.CosTimestamp);
        }
    }
}

