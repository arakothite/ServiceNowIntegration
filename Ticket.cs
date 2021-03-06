﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ServiceNowConnector
{

    public class TicketResult
    {
        public bool noResultData { get; set; }
        public string skills { get; set; }
        public string upon_approval { get; set; }
        public Location location { get; set; }
        public string expected_start { get; set; }
        public string close_notes { get; set; }
        public string impact { get; set; }
        public string urgency { get; set; }
        public string u_cause_code { get; set; }
        public string correlation_id { get; set; }
        public string description { get; set; }
        public string group_list { get; set; }
        public string priority { get; set; }
        public SysDomain sys_domain { get; set; }
        public string sys_tags { get; set; }
        public string delivery_plan { get; set; }
        public string sys_mod_count { get; set; }
        public string work_notes_list { get; set; }
        public string follow_up { get; set; }
        public string closed_at { get; set; }
        public string sla_due { get; set; }
        public string delivery_task { get; set; }
        public string sys_updated_on { get; set; }
        public string parent { get; set; }
        public string work_end { get; set; }
        public string number { get; set; }
        public ClosedBy closed_by { get; set; }
        public string work_start { get; set; }
        public string business_duration { get; set; }
        public string activity_due { get; set; }
        public string correlation_display { get; set; }
        public string company { get; set; }
        public string due_date { get; set; }
        public string active { get; set; }
        public UCaller u_caller { get; set; }
        public AssignmentGroup assignment_group { get; set; }
        public string knowledge { get; set; }
        public string made_sla { get; set; }
        public string comments_and_work_notes { get; set; }
        public string state { get; set; }
        public string user_input { get; set; }
        public string approval_set { get; set; }
        public string sys_created_on { get; set; }
        public string reassignment_count { get; set; }
        public string opened_at { get; set; }
        public string order { get; set; }
        public string short_description { get; set; }
        public string sys_updated_by { get; set; }
        public string upon_reject { get; set; }
        public string approval_history { get; set; }
        public string work_notes { get; set; }
        public string calendar_duration { get; set; }
        public string approval { get; set; }
        public string sys_id { get; set; }
        public string u_resolution_codes { get; set; }
        public string sys_created_by { get; set; }
        public AssignedTo assigned_to { get; set; }
        public string cmdb_ci { get; set; }
        public OpenedBy opened_by { get; set; }
        public string sys_class_name { get; set; }
        public string u_category { get; set; }
        public string watch_list { get; set; }
        public string time_worked { get; set; }
        public string escalation { get; set; }
        public string contact_type { get; set; }
        public string comments { get; set; }
    }

    [DataContract]
    public class Ticket
    {
        [DataMember]
        public List<TicketResult> result { get; set; }
        public bool noResultData { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in result)
            {
                sb.AppendLine("ID: " + item.sys_id + " " + item.short_description);
            }

            return sb.ToString() + " " + result.Count;
        }
    }

    [DataContract]
    public class newTicket
    {
        [DataMember]
        public TicketResult result { get; set; }
        public bool noResultData { get; set; }
    }

}
