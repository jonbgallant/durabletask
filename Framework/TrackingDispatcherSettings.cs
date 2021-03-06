﻿//  ----------------------------------------------------------------------------------
//  Copyright Microsoft Corporation
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//  http://www.apache.org/licenses/LICENSE-2.0
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//  ----------------------------------------------------------------------------------

namespace DurableTask
{
    /// <summary>
    ///     Settings to configure the Tracking Dispatcher
    /// </summary>
    public class TrackingDispatcherSettings
    {
        internal TrackingDispatcherSettings()
        {
            TransientErrorBackOffSecs = FrameworkConstants.TrackingTransientErrorBackOffSecs;
            NonTransientErrorBackOffSecs = FrameworkConstants.TrackingNonTransientErrorBackOffSecs;
            MaxConcurrentTrackingSessions = FrameworkConstants.TrackingDefaultMaxConcurrentItems;
        }

        /// <summary>
        ///     Time in seconds to wait before retrying on a transient error (e.g. communication exception). Default is 10s.
        /// </summary>
        public int TransientErrorBackOffSecs { get; set; }

        /// <summary>
        ///     Time in seconds to wait before retrying on a non-transient error. Default is 120s.
        /// </summary>
        public int NonTransientErrorBackOffSecs { get; set; }

        /// <summary>
        ///     How many tracking sessions to process concurrently. Default is 20.
        /// </summary>
        public int MaxConcurrentTrackingSessions { get; set; }

        internal TrackingDispatcherSettings Clone()
        {
            return new TrackingDispatcherSettings
            {
                TransientErrorBackOffSecs = TransientErrorBackOffSecs,
                NonTransientErrorBackOffSecs = NonTransientErrorBackOffSecs,
                MaxConcurrentTrackingSessions = MaxConcurrentTrackingSessions,
            };
        }
    }
}