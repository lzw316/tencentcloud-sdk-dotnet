/*
 * Copyright (c) 2018 Tencent. All Rights Reserved.
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

namespace TencentCloud.Smop.V20201203
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Smop.V20201203.Models;

   public class SmopClient : AbstractClient{

       private const string endpoint = "smop.tencentcloudapi.com";
       private const string version = "2020-12-03";
       private const string sdkVersion = "SDK_NET_3.0.1273";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public SmopClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public SmopClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// smop产品下线，接口也一起下线
        /// 
        /// 提交任务事件接口
        /// </summary>
        /// <param name="req"><see cref="SubmitTaskEventRequest"/></param>
        /// <returns><see cref="SubmitTaskEventResponse"/></returns>
        public Task<SubmitTaskEventResponse> SubmitTaskEvent(SubmitTaskEventRequest req)
        {
            return InternalRequestAsync<SubmitTaskEventResponse>(req, "SubmitTaskEvent");
        }

        /// <summary>
        /// smop产品下线，接口也一起下线
        /// 
        /// 提交任务事件接口
        /// </summary>
        /// <param name="req"><see cref="SubmitTaskEventRequest"/></param>
        /// <returns><see cref="SubmitTaskEventResponse"/></returns>
        public SubmitTaskEventResponse SubmitTaskEventSync(SubmitTaskEventRequest req)
        {
            return InternalRequestAsync<SubmitTaskEventResponse>(req, "SubmitTaskEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
