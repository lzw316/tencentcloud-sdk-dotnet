/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Tiw.V20190919.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WhiteboardApplicationConfig : AbstractModel
    {
        
        /// <summary>
        /// 任务类型
        /// 
        /// recording: 实时录制
        /// transcode: 文档转码
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// 存储桶名字
        /// </summary>
        [JsonProperty("BucketName")]
        public string BucketName{ get; set; }

        /// <summary>
        /// 存储桶地域
        /// </summary>
        [JsonProperty("BucketLocation")]
        public string BucketLocation{ get; set; }

        /// <summary>
        /// 资源在存储桶中的前缀
        /// </summary>
        [JsonProperty("BucketPrefix")]
        public string BucketPrefix{ get; set; }

        /// <summary>
        /// 目标CDN域名
        /// </summary>
        [JsonProperty("ResultDomain")]
        public string ResultDomain{ get; set; }

        /// <summary>
        /// 回调地址
        /// </summary>
        [JsonProperty("Callback")]
        public string Callback{ get; set; }

        /// <summary>
        /// 回调鉴权密钥
        /// </summary>
        [JsonProperty("CallbackKey")]
        public string CallbackKey{ get; set; }

        /// <summary>
        /// 配置的应用SdkAppId
        /// </summary>
        [JsonProperty("SdkAppId")]
        public long? SdkAppId{ get; set; }

        /// <summary>
        /// IM管理员UserId
        /// </summary>
        [JsonProperty("AdminUserId")]
        public string AdminUserId{ get; set; }

        /// <summary>
        /// IM管理员UserSig
        /// </summary>
        [JsonProperty("AdminUserSig")]
        public string AdminUserSig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "BucketName", this.BucketName);
            this.SetParamSimple(map, prefix + "BucketLocation", this.BucketLocation);
            this.SetParamSimple(map, prefix + "BucketPrefix", this.BucketPrefix);
            this.SetParamSimple(map, prefix + "ResultDomain", this.ResultDomain);
            this.SetParamSimple(map, prefix + "Callback", this.Callback);
            this.SetParamSimple(map, prefix + "CallbackKey", this.CallbackKey);
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "AdminUserId", this.AdminUserId);
            this.SetParamSimple(map, prefix + "AdminUserSig", this.AdminUserSig);
        }
    }
}

