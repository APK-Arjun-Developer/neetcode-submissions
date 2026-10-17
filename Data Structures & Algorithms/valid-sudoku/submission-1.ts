class Solution {
    /**
     * @param {character[][]} board
     * @return {boolean}
     */
    isValidSudoku(board: string[][]): boolean {
        const rows = new Map<number, Set<string>>();
        const cols = new Map<number, Set<string>>();
        const squares = new Map<string, Set<string>>();

        const maxLength = 9;
        const subLength = 3;

        for (let i = 0; i < maxLength; i++) {
            for (let j = 0; j < maxLength; j++) {
                const value = board[i][j];
                if (value === ".") {
                    continue;
                }
                const squareKey = Math.floor(i / subLength) + "," + Math.floor(j / subLength);

                if (
                    (rows.get(i) && rows.get(i).has(value)) ||
                    (cols.get(j) && cols.get(j).has(value)) ||
                    (squares.get(squareKey) && squares.get(squareKey).has(value))
                ) {
                    return false;
                }

                if (!rows.has(i)) {
                    rows.set(i, new Set<string>());
                }
                if (!cols.has(j)) {
                    cols.set(j, new Set<string>());
                }
                if (!squares.has(squareKey)) {
                    squares.set(squareKey, new Set<string>());
                }

                rows.get(i).add(value);
                cols.get(j).add(value);
                squares.get(squareKey).add(value);
            }
        }
        return true;
    }
}
