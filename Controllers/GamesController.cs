﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DigitopiaQuest.Data;
using DigitopiaQuest.Models;
using Microsoft.AspNetCore.Authorization;
using static DigitopiaQuest.Core.Constants;
using DigitopiaQuest.Core;

namespace DigitopiaQuest.Controllers
{
    public class GamesController : Controller
    {
        private readonly DataContext _context;

        public GamesController(DataContext context)
        {
            _context = context;
        }

        // GET: Games
        public async Task<IActionResult> Index()
        {
              return _context.Games != null ? 
                          View(await _context.Games.ToListAsync()) :
                          Problem("Entity set 'DataContext.Games'  is null.");
        }

        // GET: Games/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Games == null)
            {
                return NotFound();
            }

            var game = await _context.Games
                .FirstOrDefaultAsync(m => m.Id == id);
            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        // GET: Games/Create
        [Authorize(Roles = $"{Constants.Roles.User}")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Games/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = $"{Constants.Roles.User}")]
        public async Task<IActionResult> Create(IFormFile imageFile, [Bind("Id,NameOfGame,DescriptionOfGame,UserScore,ReleaseDateOfGame,GenreOfGame,Developer,DevCompany,ImageOfMovie")] Game game)
        {
            if (ModelState.IsValid)
            {
                if (imageFile != null && imageFile.Length > 0)// Explain!
                {
                    byte[] imageData;

                    using (var binaryReader = new BinaryReader(imageFile.OpenReadStream()))
                    {
                        imageData = binaryReader.ReadBytes((int)imageFile.Length);
                    }
                    game.ImageOfMovie = imageData;
                }
                _context.Add(game);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(game);
        }

        // GET: Games/Edit/5
        [Authorize(Roles = $"{Constants.Roles.User}")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Games == null)
            {
                return NotFound();
            }

            var game = await _context.Games.FindAsync(id);
            if (game == null)
            {
                return NotFound();
            }
            return View(game);
        }

        // POST: Games/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, IFormFile imageEdit, [Bind("Id,NameOfGame,DescriptionOfGame,UserScore,ReleaseDateOfGame,GenreOfGame,Developer,DevCompany,ImageOfMovie")] Game game)
        {
            if (id != game.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (imageEdit != null && imageEdit.Length > 0)
                    {
                        byte[] imageData;

                        using (var binaryReader = new BinaryReader(imageEdit.OpenReadStream()))
                        {
                            imageData = binaryReader.ReadBytes((int)imageEdit.Length);
                        }
                        game.ImageOfMovie = imageData;
                    }
                    _context.Update(game);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GameExists(game.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(game);
        }

        // GET: Games/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Games == null)
            {
                return NotFound();
            }

            var game = await _context.Games
                .FirstOrDefaultAsync(m => m.Id == id);
            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        // POST: Games/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = $"{Constants.Roles.Administrator}")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Games == null)
            {
                return Problem("Entity set 'DataContext.Games'  is null.");
            }
            var game = await _context.Games.FindAsync(id);
            if (game != null)
            {
                _context.Games.Remove(game);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GameExists(int id)
        {
          return (_context.Games?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
