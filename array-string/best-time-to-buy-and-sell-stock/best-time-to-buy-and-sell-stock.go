func maxProfit(prices []int) int {
    minPrice := int(^uint(0) >> 1) // max int
    maxProfit := 0

    for _, p := range prices {
        if p < minPrice {
            minPrice = p
        } else if p - minPrice > maxProfit {
            maxProfit = p - minPrice
        }
    }
    return maxProfit
}