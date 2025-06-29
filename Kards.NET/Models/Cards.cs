﻿using System;

namespace Kards.NET.Models;

public class Cards
{
    public int Id { get; set; }
    public required string CardName { get; set; }
    public string? CardDescription { get; set; }
    public DateTime CreationDate { get; set; } = DateTime.Now;
    public int DeckId { get; set; }
    public Decks Decks { get; set; } = new Decks();
}