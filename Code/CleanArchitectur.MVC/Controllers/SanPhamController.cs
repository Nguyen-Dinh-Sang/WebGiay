using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitectur.MVC.Models;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectur.MVC.Controllers
{
    public class SanPhamController : Controller
    {
        private ISanPhamService sanphamService;
        public SanPhamController(ISanPhamService sanphamService)
        {
            this.sanphamService = sanphamService;

        }
        public IActionResult Index()
        {
            return View(sanphamService.GetSanPhams());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(SanPhamDTO sanphamDTO)
        {
            if (ModelState.IsValid)
            {
                sanphamDTO.Id = 0;
                sanphamService.Create(sanphamDTO);
                return RedirectToAction("Index");
            }
            return View(sanphamDTO);
        }
        [HttpGet]
        public IActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            else
            {
                var sp = sanphamService.GetSanPham(Id);
                return View(sp);
            }
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int? Id)
        {
            sanphamService.Remove(Id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            else
            {
                var sp = sanphamService.GetSanPham(Id);
                return View(sp);
            }
        }
        [HttpPost, ActionName("Edit")]
        public IActionResult EditConfirm(SanPhamDTO sanpham)
        {
            if (ModelState.IsValid)
            {
                sanphamService.Create(sanpham);
                return RedirectToAction("Index");
            }
            return View(sanpham);
        }
        public IActionResult Details(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            else
            {
                var sanphamViewDetails = new SanPhamViewDetails()
                {
                    SanPham = sanphamService.GetSanPham(Id),

                };
                return View(sanphamService.GetSanPham(Id));
            }
        }
    }
}