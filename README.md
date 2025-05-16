       +Compare(Player, Player): int
    }

    enum PlayerOrder {
        ByScore
        ByName
        ByNameReverse
    }

    PlayerController --> PlayerView
    PlayerController --> Player
    PlayerController --> CompareByName
