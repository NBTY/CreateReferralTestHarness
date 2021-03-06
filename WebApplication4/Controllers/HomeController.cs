﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CreateReferralTestHarness.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult TrackReferrals()
        {
            ViewBag.Message = "Track Referrals.";

            return View();
        }
        public ActionResult TrackRewards()
        {
            ViewBag.Message = "Track Rewards.";

            return View();
        }

        public ActionResult GetRewardBalance()
        {
            ViewBag.Message = "Track Rewards.";

            return View();
        }
    }
}