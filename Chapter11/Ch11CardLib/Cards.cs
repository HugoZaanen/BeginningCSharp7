﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11CardLib
{
    class Cards : CollectionBase
    {
        public void Add(Card newCard) => List.Add(newCard);

        public void Remove(Card oldCard) => List.Remove(oldCard);

        public Card this[int cardIndex]
        {
            get { return (Card)List[cardIndex]; }
            set { List[cardIndex] = value; }
        }

        /// <summary>
        /// Utility method for cpying card instance into another Cards
        /// instance-used in Deck.shuffle(). This implementation assumes that
        /// source and target collections are the same size.
        /// </summary>
        /// <param name="targetCards"></param>
        public void CopyTo(Cards targetCards)
        {
            for(int index = 0; index < this.Count;index++)
            {
                targetCards[index] = this[index];
            }
        }

        /// <summary>
        /// Check to see if Cards collection contains a particular card.
        /// This calls the Contains() method of the ArrayList for the collection,
        /// which you acces through the InnerList property
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        public bool Contains(Card card) => InnerList.Contains(card);
    }
}
