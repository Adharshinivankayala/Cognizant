public class SearchDemo {

    public static Product linearSearch(Product[] products, int searchId) {
        for (int i = 0; i < products.length; i++) {
            if (products[i].productId == searchId) {
                return products[i];
            }
        }
        return null;
    }

    public static Product binarySearch(Product[] products, int searchId) {
        int left = 0;
        int right = products.length - 1;

        while (left <= right) {
            int mid = (left + right) / 2;

            if (products[mid].productId == searchId) {
                return products[mid];
            } else if (products[mid].productId < searchId) {
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }

        return null;
    }

    public static void main(String[] args) {

        Product[] products = {
                new Product(101, "Laptop", "Electronics"),
                new Product(102, "Shoes", "Fashion"),
                new Product(103, "Mobile", "Electronics"),
                new Product(104, "Watch", "Accessories"),
                new Product(105, "Book", "Education")
        };

        int searchId = 104;

        System.out.println("Linear Search Result:");
        Product linearResult = linearSearch(products, searchId);

        if (linearResult != null) {
            linearResult.displayProduct();
        } else {
            System.out.println("Product not found");
        }

        System.out.println();

        System.out.println("Binary Search Result:");
        Product binaryResult = binarySearch(products, searchId);

        if (binaryResult != null) {
            binaryResult.displayProduct();
        } else {
            System.out.println("Product not found");
        }

        System.out.println();

        System.out.println("Time Complexity Analysis:");
        System.out.println("Linear Search: O(n)");
        System.out.println("Binary Search: O(log n)");
        System.out.println("Binary Search is better for large sorted product lists.");
    }
}