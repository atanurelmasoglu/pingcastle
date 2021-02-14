﻿//
// Copyright (c) Ping Castle. All rights reserved.
// https://www.pingcastle.com
//
// Licensed under the Non-Profit OSL. See LICENSE file in the project root for full license information.
//
using PingCastle.Rules;

namespace PingCastle.Healthcheck.Rules
{
    [RuleModel("A-AdminSDHolder", RiskRuleCategory.Anomalies, RiskModelCategory.TemporaryAdmins)]
    [RuleComputation(RuleComputationType.TriggerOnThreshold, 50, Threshold: 50, Order: 1)]
    [RuleComputation(RuleComputationType.TriggerOnThreshold, 45, Threshold: 45, Order: 2)]
    [RuleComputation(RuleComputationType.TriggerOnThreshold, 40, Threshold: 40, Order: 3)]
    [RuleComputation(RuleComputationType.TriggerOnThreshold, 35, Threshold: 35, Order: 4)]
    [RuleComputation(RuleComputationType.TriggerOnThreshold, 30, Threshold: 30, Order: 5)]
    [RuleComputation(RuleComputationType.TriggerOnThreshold, 25, Threshold: 25, Order: 6)]
    [RuleComputation(RuleComputationType.TriggerOnThreshold, 20, Threshold: 20, Order: 7)]
    [RuleComputation(RuleComputationType.TriggerOnPresence, 15, Order: 8)]
    [RuleANSSI("R40", "paragraph.3.6.3.1")]
    [RuleMaturityLevel(3)]
    public class HeatlcheckRuleAnomalyAdminSDHolder : RuleBase<HealthcheckData>
    {
        protected override int? AnalyzeDataNew(HealthcheckData healthcheckData)
        {
            return healthcheckData.AdminSDHolderNotOKCount;
        }
    }
}
