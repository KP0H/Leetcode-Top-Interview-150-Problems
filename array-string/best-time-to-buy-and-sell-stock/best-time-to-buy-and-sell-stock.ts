function maxProfit(prices: number[]): number {
    let minPrice = 0;
    let maxProfit = 0;

    for (const p of prices) {
        if (p < minPrice) minPrice = p
        else if (p - minPrice > maxProfit) maxProfit = p - minPrice
    }

    return maxProfit
};